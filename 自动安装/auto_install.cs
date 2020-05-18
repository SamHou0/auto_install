using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自动安装
{
    public partial class auto_install : Form
    {
        private bool close_enable = true;

        public auto_install()
        {
            InitializeComponent();
        }

        private void create_new_folder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"install\");
            progressBar1.Value += 20;
            create_new_folder.Enabled = false;
            install_button.Enabled = true;
            close_enable = false;
            Process.Start("Explorer.exe", @"install\");
        }

        private void auto_install_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (progressBar1.Value!=100&&(progressBar1.Value!=0||progressBar1.Value!=20)&&close_enable==false)
            {
                MessageBox.Show("你现在不能退出！请点击取消安装以强制退出！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel=true;
            }
        }

        private void install_button_Click(object sender, EventArgs e)
        {
            backgroundWorker_install.RunWorkerAsync();
            cancel_button.Enabled = true;
            install_button.Enabled = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("你真的要退出吗？安装尚未完成，退出可能导致安装不完整！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult==DialogResult.Yes)
            {
                close_enable = true;
                Environment.Exit(0);
            }
        }

        private void auto_install_Load(object sender, EventArgs e)
        {
            cancel_button.Enabled = false;
            install_button.Enabled = false;
        }

        private void backgroundWorker_install_DoWork(object sender, DoWorkEventArgs e)
        {
            int now_percent = 0;
            var Files = Directory.GetFiles(@"install\", "*.*");
            if (Files.Length==0)
            {
                MessageBox.Show("请添加安装程序后重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int step = 80 / Files.Length;
            Add(Files);
            now_percent += 20;
            backgroundWorker_install.ReportProgress(now_percent);
            foreach (var item in Files)
            {
                Process process = new Process();
                process.StartInfo.FileName = item;
                try
                {
                    process.Start();
                }
                catch
                {
                    
                }
                while (true)
                {
                    if (Process.GetProcessesByName(process.ProcessName).ToList().Count == 0)
                    {
                        now_percent += step;
                        backgroundWorker_install.ReportProgress(now_percent);
                        break;
                    }
                }
            }
        }

        private void Add(string[] Files)
        {
        }

        private void backgroundWorker_install_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage==20)
            {
                var Files = Directory.GetFiles(@"install\", "*.*");
                foreach (var item in Files)
                {
                    install_list.Items.Add(item);
                }
            }
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_install_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            MessageBox.Show("安装操作已成功完成。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cancel_button.Enabled = false;
            label5.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://icons8.com/");
        }
    }
}