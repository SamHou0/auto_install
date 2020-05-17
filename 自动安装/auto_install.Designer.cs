namespace 自动安装
{
    partial class auto_install
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auto_install));
            this.install_list = new System.Windows.Forms.ListBox();
            this.create_new_folder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.install_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker_install = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // install_list
            // 
            this.install_list.FormattingEnabled = true;
            this.install_list.ItemHeight = 15;
            this.install_list.Location = new System.Drawing.Point(20, 46);
            this.install_list.Name = "install_list";
            this.install_list.Size = new System.Drawing.Size(763, 244);
            this.install_list.TabIndex = 1;
            // 
            // create_new_folder
            // 
            this.create_new_folder.Location = new System.Drawing.Point(688, 296);
            this.create_new_folder.Name = "create_new_folder";
            this.create_new_folder.Size = new System.Drawing.Size(96, 49);
            this.create_new_folder.TabIndex = 2;
            this.create_new_folder.Text = "建立安装文件夹";
            this.create_new_folder.UseVisualStyleBackColor = true;
            this.create_new_folder.Click += new System.EventHandler(this.create_new_folder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "第一步";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "第二步";
            // 
            // install_button
            // 
            this.install_button.Location = new System.Drawing.Point(688, 351);
            this.install_button.Name = "install_button";
            this.install_button.Size = new System.Drawing.Size(95, 41);
            this.install_button.TabIndex = 8;
            this.install_button.Text = "开始安装";
            this.install_button.UseVisualStyleBackColor = true;
            this.install_button.Click += new System.EventHandler(this.install_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "自动开始安装，等待安装完成";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(688, 398);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(95, 40);
            this.cancel_button.TabIndex = 12;
            this.cancel_button.Text = "取消安装";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 322);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(662, 55);
            this.progressBar1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "建立安装文件夹-点击按钮";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "添加文件-手动添加到生成的install文件夹";
            // 
            // backgroundWorker_install
            // 
            this.backgroundWorker_install.WorkerReportsProgress = true;
            this.backgroundWorker_install.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_install_DoWork);
            this.backgroundWorker_install.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_install_ProgressChanged);
            this.backgroundWorker_install.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_install_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(502, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "当你正在安装时，除非进程卡死，否则不建议强制退出！可能会造成异常！";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "安装操作已成功完成。如需安装更多，请重启应用程序。";
            this.label5.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(617, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 15);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "图标由icon8.com提供";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // auto_install
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.install_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.create_new_folder);
            this.Controls.Add(this.install_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "auto_install";
            this.Text = "auto_install";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.auto_install_FormClosing);
            this.Load += new System.EventHandler(this.auto_install_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox install_list;
        private System.Windows.Forms.Button create_new_folder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button install_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker_install;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}