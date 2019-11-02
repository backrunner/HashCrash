using MD5Crash.Model;
using MD5Crash.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5Crash
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 线程数量
        private int threadCount;

        // 每一轮跑的数字量
        private int roundCount;

        // 当前轮次
        private int currentRound;

        // 截取 hash 的起始结束
        private int hashStart;
        private int hashStop;

        // 碰撞 hash 的数量
        private int crashCount;
        private int currentCrashCount;

        // 碰撞值
        private string crashHash;

        // 算法
        private string algorithm;

        // flags
        private bool working;

        // delegates
        public delegate void HashFoundHandler(string num, string hash);
        public delegate void SearchFinishedHandler();
        public delegate void OutputHandler(string message);
        public delegate void UpdateRoundCountHandler(int count);

        // events
        public event HashFoundHandler HashFoundEvent;
        public event SearchFinishedHandler SearchFinishedEvent;
        public event OutputHandler OutputEvent;
        public event UpdateRoundCountHandler UpdateRoundEvent;

        // lock
        private object currentCrashCountLock = new object();

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // init textblock
            tb_roundCount.Text = "1000000";
            tb_hashStart.Text = "0";
            tb_hashStop.Text = "6";
            tb_crashCount.Text = "3";
            tb_thread.Text = "8";
            // init combobox
            cb_algorithm.SelectedIndex = 0;
            // bind events
            HashFoundEvent += MainWindow_HashFoundEvent;
            SearchFinishedEvent += MainWindow_SearchFinishedEvent;
            OutputEvent += MainWindow_OutputEvent;
            UpdateRoundEvent += MainWindow_UpdateRoundEvent;
        }

        private void MainWindow_UpdateRoundEvent(int count)
        {
            var update = new Action(() =>
            {
                tb_round.Text = currentRound.ToString();
            });
            this.Invoke(update);
        }

        private void UpdateRoundCount(int count)
        {
            UpdateRoundEvent?.Invoke(count);
        }

        private void MainWindow_OutputEvent(string message)
        {
            var update = new Action(() =>
            {
                rb_output.Text += message + "\r\n";
                rb_output.SelectionStart = rb_output.Text.Length;
                rb_output.ScrollToCaret();
            });
            this.Invoke(update);
        }

        private void Log(string message)
        {
            string s = DateTime.Now.ToString("HH:mm:ss ") + ": " + message;
            OutputEvent?.Invoke(s);
        }

        private void MainWindow_SearchFinishedEvent()
        {
            var update = new Action(() =>
            {
                working = false;
                StopSearching();
                Log("Hash 搜索完成");
            });
            this.Invoke(update);
        }

        private void SearchFinished()
        {
            SearchFinishedEvent?.Invoke();
        }

        private void MainWindow_HashFoundEvent(string num, string hash)
        {
            var update = new Action(() =>
            {
                lb_res.Items.Add(num + " " + hash);
            });
            this.Invoke(update);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // fetch values
            threadCount = int.Parse(tb_thread.Text);
            roundCount = int.Parse(tb_roundCount.Text);
            hashStart = int.Parse(tb_hashStart.Text);
            hashStop = int.Parse(tb_hashStop.Text);
            crashCount = int.Parse(tb_crashCount.Text);
            crashHash = tb_hash.Text.ToLower().Trim();

            algorithm = cb_algorithm.Text;

            // init values
            currentRound = 1;
            currentCrashCount = 0;
            working = true;

            // set controls
            tb_thread.Enabled = false;
            tb_roundCount.Enabled = false;
            tb_hash.Enabled = false;
            tb_hashStart.Enabled = false;
            tb_hashStop.Enabled = false;
            tb_crashCount.Enabled = false;
            cb_algorithm.Enabled = false;

            btn_start.Enabled = false;
            btn_stop.Enabled = true;

            lb_res.Items.Clear();

            tb_round.Text = currentRound.ToString();

            Log("正在开始搜索 Hash......");

            ThreadPool.QueueUserWorkItem(new WaitCallback(SearchHash), null);
        }

        private void SearchHash(object state)
        {
            // start threads
            while (currentCrashCount < crashCount)
            {
                Log("正在启动第[" + currentRound.ToString() + "]轮搜索......");
                long roundStart = 1 + (currentRound - 1) * roundCount;
                long roundEnd = roundCount * currentRound;
                long eachThreadCount = roundCount / threadCount;
                // init signals
                List<ManualResetEvent> signals = new List<ManualResetEvent>();
                for (int i = 0; i < threadCount; i++)
                {
                    // calc num start and stop for thread
                    long numStart = roundStart + i * eachThreadCount;
                    long numStop;
                    if (i == threadCount - 1)
                    {
                        numStop = roundEnd;
                    }
                    else
                    {
                        numStop = roundStart + (i + 1) * eachThreadCount;
                    }
                    // init signal for thread
                    ManualResetEvent signal = new ManualResetEvent(false);
                    signals.Add(signal);
                    // create thread
                    ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadWork), new WorkState(numStart, numStop, hashStart, hashStop, crashHash.ToUpper(), signal));
                }
                // wait for all threads in this round finish their work
                WaitHandle.WaitAll(signals.ToArray());
                // bump up round count
                currentRound++;
                UpdateRoundCount(currentRound);
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            StopSearching();
        }

        private void StopSearching()
        {
            // set flags
            working = false;

            // set control
            tb_thread.Enabled = true;
            tb_roundCount.Enabled = true;
            tb_hash.Enabled = true;
            tb_hashStart.Enabled = true;
            tb_hashStop.Enabled = true;
            tb_crashCount.Enabled = true;
            cb_algorithm.Enabled = true;

            btn_start.Enabled = true;
            btn_stop.Enabled = false;
        }

        private void ThreadWork(object state)
        {
            // flag working is false means thread needs to stop working
            if (!working)
            {
                return;
            }
            WorkState workState = (WorkState)state;
            int hashLength = workState.hashStop - workState.hashStart;
            if (workState.algorithm == "MD5")
            {
                for (long i = workState.numStart; i <= workState.numStop; i++)
                {
                    string hash = HashUtil.md5(i);
                    if (hash.Substring(workState.hashStart, hashLength) == workState.hash)
                    {
                        AddResult(i.ToString(), hash);
                    }
                }
            }
            workState.finishSignal.Set();
        }

        private void AddResult(string num, string hash)
        {
            Log("找到一个结果");
            HashFoundEvent?.Invoke(num, hash);
            lock (currentCrashCountLock)
            {
                currentCrashCount++;
                if (currentCrashCount >= crashCount)
                {
                    // invoke finish event
                    SearchFinished();
                }
            }  
        }
    }
}
