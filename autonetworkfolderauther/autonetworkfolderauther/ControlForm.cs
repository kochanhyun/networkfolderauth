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
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void ControlOpenButton_Click(object sender, EventArgs e)
        {
            // 고급 공유 설정 오픈
            Process StartSetCmd = new Process();
            StartSetCmd.StartInfo.FileName = "cmd.exe";
            StartSetCmd.StartInfo.RedirectStandardInput = true;
            StartSetCmd.StartInfo.RedirectStandardOutput = true;
            StartSetCmd.StartInfo.CreateNoWindow = true;
            StartSetCmd.StartInfo.UseShellExecute = false;
            StartSetCmd.Start();
            StartSetCmd.StandardInput.WriteLine("control.exe /name Microsoft.NetworkAndSharingCenter /page Advanced");
            StartSetCmd.StandardInput.Flush();
            StartSetCmd.StandardInput.Close();
            StartSetCmd.WaitForExit();
        }
    }
}
