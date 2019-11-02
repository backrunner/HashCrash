using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MD5Crash.Model
{
    public class WorkState
    {
        public long numStart;
        public long numStop;
        public int hashStart;
        public int hashStop;
        public string hash;
        public string algorithm;
        // finish signal
        public ManualResetEvent finishSignal;
        public WorkState(long numStart, long numStop, int hashStart, int hashStop, String hash, ManualResetEvent e)
        {
            this.numStart = numStart;
            this.numStop = numStop;
            this.hashStart = hashStart;
            this.hashStop = hashStop;
            this.hash = hash;
            this.algorithm = "MD5";
            this.finishSignal = e;
        }
        public WorkState(long numStart, long numStop, int hashStart, int hashStop, String hash, String algorithm, ManualResetEvent e)
        {
            this.numStart = numStart;
            this.numStop = numStop;
            this.hashStart = hashStart;
            this.hashStop = hashStop;
            this.hash = hash;
            this.algorithm = algorithm;
            this.finishSignal = e;
        }
    }
}
