namespace myNetstatView
{
    partial class myNetstatView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.udpCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcpCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.describeText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pidInfoData = new System.Windows.Forms.DataGridView();
            this.pidIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.pidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remotePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pidInfoData)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.udpCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tcpCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.allCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(947, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(185, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计信息";
            // 
            // udpCount
            // 
            this.udpCount.AutoSize = true;
            this.udpCount.Location = new System.Drawing.Point(91, 47);
            this.udpCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.udpCount.Name = "udpCount";
            this.udpCount.Size = new System.Drawing.Size(11, 12);
            this.udpCount.TabIndex = 5;
            this.udpCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "UDP连接数:";
            // 
            // tcpCount
            // 
            this.tcpCount.AutoSize = true;
            this.tcpCount.Location = new System.Drawing.Point(91, 25);
            this.tcpCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tcpCount.Name = "tcpCount";
            this.tcpCount.Size = new System.Drawing.Size(11, 12);
            this.tcpCount.TabIndex = 3;
            this.tcpCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCP连接数:";
            // 
            // allCount
            // 
            this.allCount.AutoSize = true;
            this.allCount.Location = new System.Drawing.Point(91, 69);
            this.allCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allCount.Name = "allCount";
            this.allCount.Size = new System.Drawing.Size(11, 12);
            this.allCount.TabIndex = 1;
            this.allCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所有连接数:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.describeText);
            this.groupBox2.Location = new System.Drawing.Point(947, 356);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(185, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "说明信息";
            // 
            // describeText
            // 
            this.describeText.Location = new System.Drawing.Point(5, 18);
            this.describeText.Margin = new System.Windows.Forms.Padding(2);
            this.describeText.Multiline = true;
            this.describeText.Name = "describeText";
            this.describeText.ReadOnly = true;
            this.describeText.Size = new System.Drawing.Size(170, 240);
            this.describeText.TabIndex = 0;
            this.describeText.TabStop = false;
            this.describeText.Text = "多线程版本，仅仅是个显示监听端口的应用程序名称的小工具";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pidInfoData);
            this.groupBox3.Location = new System.Drawing.Point(8, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(935, 610);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "监听信息";
            // 
            // pidInfoData
            // 
            this.pidInfoData.AllowUserToAddRows = false;
            this.pidInfoData.AllowUserToDeleteRows = false;
            this.pidInfoData.AllowUserToResizeColumns = false;
            this.pidInfoData.AllowUserToResizeRows = false;
            this.pidInfoData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pidInfoData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pidInfoData.ColumnHeadersHeight = 24;
            this.pidInfoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pidInfoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidIcon,
            this.pidName,
            this.pid,
            this.pidProtocol,
            this.localIp,
            this.localPort,
            this.remoteIP,
            this.remotePort});
            this.pidInfoData.GridColor = System.Drawing.SystemColors.Control;
            this.pidInfoData.Location = new System.Drawing.Point(4, 18);
            this.pidInfoData.Margin = new System.Windows.Forms.Padding(2);
            this.pidInfoData.Name = "pidInfoData";
            this.pidInfoData.ReadOnly = true;
            this.pidInfoData.RowHeadersVisible = false;
            this.pidInfoData.RowTemplate.Height = 24;
            this.pidInfoData.RowTemplate.ReadOnly = true;
            this.pidInfoData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pidInfoData.Size = new System.Drawing.Size(925, 585);
            this.pidInfoData.TabIndex = 0;
            // 
            // pidIcon
            // 
            this.pidIcon.HeaderText = "图标";
            this.pidIcon.MinimumWidth = 40;
            this.pidIcon.Name = "pidIcon";
            this.pidIcon.ReadOnly = true;
            this.pidIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pidIcon.Width = 40;
            // 
            // pidName
            // 
            this.pidName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pidName.HeaderText = "进程名称";
            this.pidName.MinimumWidth = 200;
            this.pidName.Name = "pidName";
            this.pidName.ReadOnly = true;
            this.pidName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pid
            // 
            this.pid.HeaderText = "进程号";
            this.pid.MinimumWidth = 100;
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pidProtocol
            // 
            this.pidProtocol.HeaderText = "协议";
            this.pidProtocol.MinimumWidth = 60;
            this.pidProtocol.Name = "pidProtocol";
            this.pidProtocol.ReadOnly = true;
            this.pidProtocol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pidProtocol.Width = 60;
            // 
            // localIp
            // 
            this.localIp.HeaderText = "本地IP";
            this.localIp.MinimumWidth = 120;
            this.localIp.Name = "localIp";
            this.localIp.ReadOnly = true;
            this.localIp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.localIp.Width = 120;
            // 
            // localPort
            // 
            this.localPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.localPort.HeaderText = "本地端口";
            this.localPort.MinimumWidth = 120;
            this.localPort.Name = "localPort";
            this.localPort.ReadOnly = true;
            this.localPort.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.localPort.Width = 120;
            // 
            // remoteIP
            // 
            this.remoteIP.HeaderText = "远程IP";
            this.remoteIP.MinimumWidth = 120;
            this.remoteIP.Name = "remoteIP";
            this.remoteIP.ReadOnly = true;
            this.remoteIP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.remoteIP.Width = 120;
            // 
            // remotePort
            // 
            this.remotePort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.remotePort.HeaderText = "远程端口";
            this.remotePort.MinimumWidth = 120;
            this.remotePort.Name = "remotePort";
            this.remotePort.ReadOnly = true;
            this.remotePort.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.remotePort.Width = 120;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(5, 19);
            this.start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(85, 35);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "获取";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.start_btn);
            this.groupBox4.Controls.Add(this.stop_btn);
            this.groupBox4.Location = new System.Drawing.Point(947, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 65);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "控制";
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(96, 19);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(2);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(85, 35);
            this.stop_btn.TabIndex = 4;
            this.stop_btn.Text = "终止";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(947, 186);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 165);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "系统信息";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "系统类型:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "MyT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "4096M";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "Win64";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "当前时间:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "计算机名:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "CPU数:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Administrator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "用户名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Linux";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作系统:";
            // 
            // myNetstatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 627);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "myNetstatView";
            this.Text = "myNetstatView V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pidInfoData)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tcpCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label udpCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.DataGridView pidInfoData;
        private System.Windows.Forms.TextBox describeText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewImageColumn pidIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn localIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn localPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn remotePort;
    }
}

