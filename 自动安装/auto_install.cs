using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自动安装
{
    public partial class auto_install : Form
    {
        bool close_enable = true;
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
            cancel_button.Enabled = true;
            install_button.Enabled = false;
            var Files=Directory.GetFiles(@"install\", "*.*");
            int step = 60 / Files.Length;
            foreach (var item in Files)
            {
                install_list.Items.Add(item);
            }
            progressBar1.Value += 20;
            foreach (var item in Files)
            {
                Process process = new Process();
                process.StartInfo.FileName = item;
                try
                {
                    process.Start();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                while (true)
                {
                    if (Process.GetProcessesByName(process.ProcessName).ToList().Count==0)
                    {
                        progressBar1.Value += step;
                        break;
                    }
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("你真的要退出吗？安装尚未完成，退出可能导致安装不完整！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult==DialogResult.Yes)
            {
                close_enable = true;
                Application.Exit();
            }
        }

        private void auto_install_Load(object sender, EventArgs e)
        {
            cancel_button.Enabled = false;
            install_button.Enabled = false;
        }
    }
}
