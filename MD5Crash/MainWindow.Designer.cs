namespace MD5Crash
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_roundCount = new System.Windows.Forms.TextBox();
            this.tb_thread = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_hashStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_hashStop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_algorithm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.rb_output = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_hash = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_round = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_crashCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lv_res = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "每轮碰撞数量：";
            // 
            // tb_roundCount
            // 
            this.tb_roundCount.Location = new System.Drawing.Point(15, 28);
            this.tb_roundCount.Name = "tb_roundCount";
            this.tb_roundCount.Size = new System.Drawing.Size(100, 21);
            this.tb_roundCount.TabIndex = 1;
            // 
            // tb_thread
            // 
            this.tb_thread.Location = new System.Drawing.Point(135, 28);
            this.tb_thread.Name = "tb_thread";
            this.tb_thread.Size = new System.Drawing.Size(100, 21);
            this.tb_thread.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "线程数量：";
            // 
            // tb_hashStart
            // 
            this.tb_hashStart.Location = new System.Drawing.Point(15, 81);
            this.tb_hashStart.Name = "tb_hashStart";
            this.tb_hashStart.Size = new System.Drawing.Size(100, 21);
            this.tb_hashStart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hash截取起始：";
            // 
            // tb_hashStop
            // 
            this.tb_hashStop.Location = new System.Drawing.Point(135, 81);
            this.tb_hashStop.Name = "tb_hashStop";
            this.tb_hashStop.Size = new System.Drawing.Size(100, 21);
            this.tb_hashStop.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hash截取结束：";
            // 
            // cb_algorithm
            // 
            this.cb_algorithm.FormattingEnabled = true;
            this.cb_algorithm.Location = new System.Drawing.Point(256, 82);
            this.cb_algorithm.Name = "cb_algorithm";
            this.cb_algorithm.Size = new System.Drawing.Size(96, 20);
            this.cb_algorithm.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "算法：";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(507, 28);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(592, 28);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 11;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // rb_output
            // 
            this.rb_output.Location = new System.Drawing.Point(371, 81);
            this.rb_output.Name = "rb_output";
            this.rb_output.ReadOnly = true;
            this.rb_output.Size = new System.Drawing.Size(296, 357);
            this.rb_output.TabIndex = 12;
            this.rb_output.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "输出：";
            // 
            // tb_hash
            // 
            this.tb_hash.Location = new System.Drawing.Point(15, 132);
            this.tb_hash.Name = "tb_hash";
            this.tb_hash.Size = new System.Drawing.Size(220, 21);
            this.tb_hash.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "碰撞值：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "当前轮数：";
            // 
            // tb_round
            // 
            this.tb_round.Location = new System.Drawing.Point(371, 30);
            this.tb_round.Name = "tb_round";
            this.tb_round.ReadOnly = true;
            this.tb_round.Size = new System.Drawing.Size(100, 21);
            this.tb_round.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "碰撞结果：";
            // 
            // tb_crashCount
            // 
            this.tb_crashCount.Location = new System.Drawing.Point(256, 132);
            this.tb_crashCount.Name = "tb_crashCount";
            this.tb_crashCount.Size = new System.Drawing.Size(96, 21);
            this.tb_crashCount.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "碰撞数量：";
            // 
            // lv_res
            // 
            this.lv_res.HideSelection = false;
            this.lv_res.Location = new System.Drawing.Point(12, 186);
            this.lv_res.Name = "lv_res";
            this.lv_res.Size = new System.Drawing.Size(340, 252);
            this.lv_res.TabIndex = 21;
            this.lv_res.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.lv_res);
            this.Controls.Add(this.tb_crashCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_round);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_hash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rb_output);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_algorithm);
            this.Controls.Add(this.tb_hashStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_hashStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_thread);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_roundCount);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "MD5Crash by BackRunner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_roundCount;
        private System.Windows.Forms.TextBox tb_thread;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hashStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_hashStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_algorithm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.RichTextBox rb_output;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_hash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_round;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_crashCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lv_res;
    }
}

