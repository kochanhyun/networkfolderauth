using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

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
            ControlForm newForm = new ControlForm();
            newForm.ShowDialog();
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string selected = dialog.SelectedPath;
            FolderPathView.Text = selected;
        }
    }
}
