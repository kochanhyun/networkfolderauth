using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Diagnostics;

namespace autonetworkfolderauther
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            // 설명창 생성
            ControlForm ControlForm = new ControlForm();
            ControlForm.ShowDialog();
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string selected = dialog.SelectedPath;
            FolderPathView.Text = selected;
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            PasswordForm PasswordForm = new PasswordForm(this);
            PasswordForm.ShowDialog();
        }

        private void ShareFolderAddButton_Click(object sender, EventArgs e)
        {
            string Authchecked;

            if (Readrb.Checked == true)
            {
                Authchecked = "READ";
            } else if (Readnwriterb.Checked == true)
            {
                Authchecked = "FULL";
            } else
            {
                goto nochecked;
            }
            
            if (String.IsNullOrEmpty(Idtextbox.Text) == true && String.IsNullOrEmpty(PassTextbox.Text) == true && String.IsNullOrEmpty(ShareFolderNameTextbox.Text) == true)
            {
                goto nochecked;
            }

            // 공유 폴더 생성
            Process StartSetCmd = new Process();
            StartSetCmd.StartInfo.FileName = "cmd.exe";
            StartSetCmd.StartInfo.RedirectStandardInput = true;
            StartSetCmd.StartInfo.RedirectStandardOutput = true;
            StartSetCmd.StartInfo.CreateNoWindow = true;
            StartSetCmd.StartInfo.UseShellExecute = false;
            StartSetCmd.Start();
            StartSetCmd.StandardInput.WriteLine("net user " + Idtextbox.Text + " " + PassTextbox.Text + " /add");
            StartSetCmd.StandardInput.WriteLine("net share Upload_Address=" + FolderPathView.Text + " /GRANT:Administrator, FULL " + "/GRANT:" + Idtextbox.Text + ", " + Authchecked);
            StartSetCmd.StandardInput.Flush();
            StartSetCmd.StandardInput.Close();
            StartSetCmd.WaitForExit();

            // 항목이 지정되지 않았다
            nochecked:;

            // 초기화
            FolderPathView.Text = null;
            Idtextbox.Text = null;
            PassTextbox.Text = null;
            ShareFolderNameTextbox.Text = null;
            Readrb.Checked = false;
            Readnwriterb.Checked = false;
        }
    }
}
