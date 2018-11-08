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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 설명창 생성
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 나눔 글꼴 설정
            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("NanumBarunGothic.ttf");

            Font NanumFont = new Font(privateFont.Families[0], 9f);

            button1.Font = NanumFont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string selected = dialog.SelectedPath;
            textBox1.Text = selected;
        }
    }
}
