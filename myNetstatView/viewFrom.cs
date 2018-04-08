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

namespace myNetstatView
{
    public partial class myNetstatView : Form
    {
        public myNetstatView()
        {
            // 核心代码抄的网上的,Tea
            InitializeComponent();
            string osVersionName = GetOsVersion(Environment.OSVersion.Version);
            label4.Text = osVersionName;
            label7.Text = Environment.UserName;
            label9.Text = Environment.ProcessorCount.ToString();
            if (Environment.Is64BitOperatingSystem)
            {
                label11.Text = "64bit";
            }
            else {
                label11.Text = "32bit";
            }
            label13.Text = SystemInformation.ComputerName;
            label15.Text = DateTime.Now.ToLongDateString().ToString();
        }

        private string GetOsVersion(Version ver)
        {
            string strClient = "";
            if (ver.Major == 5 && ver.Minor == 1)
            {
                strClient = "Win XP";
            }
            else if (ver.Major == 6 && ver.Minor == 0)
            {
                strClient = "Win Vista";
            }
            else if (ver.Major == 6 && ver.Minor == 1)
            {
                strClient = "Win 7";
            }
            else if (ver.Major == 5 && ver.Minor == 0)
            {
                strClient = "Win 2000";
            }
            else
            {
                strClient = "未知";
            }
            return strClient;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            clearData();
            Thread mainThread = new Thread(ThreadMethod);
            mainThread.IsBackground = true;
            mainThread.Start();
        }

        private void clearData()
        {
            pidInfoData.Rows.Clear();
            tcpCount.Text = "0";
            udpCount.Text = "0";
            allCount.Text = "0";
            start_btn.Enabled = false;
        }

        /// <summary>  
        /// 多线程执行指定方法  
        /// </summary>  
        private void ThreadMethod()
        {
            /*
            while (true)
            {
                Thread.Sleep(1000);  //线程暂停100毫秒  
                ThreadStart();
            }
            */
            ThreadStart();
        }

        private delegate void ThreadStartDelegate();
        /// <summary>  
        /// 线程方法  
        /// </summary>  
        private void ThreadStart()
        {
            var tcpCountInt = 0;
            var udpCountInt = 0;
            if (allCount.InvokeRequired || tcpCount.InvokeRequired || udpCount.InvokeRequired || pidInfoData.InvokeRequired)
            {
                ThreadStartDelegate delegateMe = ThreadStart;
                pidInfoData.Invoke(delegateMe);
            }
            else
            {
                var tcpResult = NetProcessAPI.GetAllTcpConnections();
                var udpResult = NetProcessAPI.GetAllUdpConnections();
                foreach (var pid in tcpResult)
                {
                    if (pid.owningPid > 0)
                    {
                        tcpCountInt++;
                        var pid_icon = ProcessAPI.GetIcon(pid.owningPid, true);
                        var pid_name = ProcessAPI.GetProcessNameByPID(pid.owningPid);
                        pidInfoData.Rows.Add(pid_icon, pid_name, pid.owningPid.ToString(), "TCP", pid.LocalAddress.ToString(), pid.LocalPort.ToString(), pid.RemoteAddress.ToString(), pid.RemotePort.ToString());
                    }
                }
                foreach (var pid in udpResult)
                {
                    if (pid.owningPid > 0)
                    {
                        udpCountInt++;
                        var pid_icon = ProcessAPI.GetIcon(pid.owningPid, true);
                        var pid_name = ProcessAPI.GetProcessNameByPID(pid.owningPid);
                        pidInfoData.Rows.Add(pid_icon, pid_name, pid.owningPid.ToString(), "UDP", pid.LocalAddress.ToString(), pid.LocalPort.ToString(), "", "");
                    }
                }
                tcpCount.Text = tcpCountInt.ToString();
                udpCount.Text = udpCountInt.ToString();
                allCount.Text = (tcpCountInt + udpCountInt).ToString();
                start_btn.Enabled = true;
            }
        }


        private void stop_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}