using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace autonetworkfolderauther
{
    public partial class PasswordForm : Form
    {
        MainForm MainFormm;


        public PasswordForm(MainForm _Mainform)
        {
            InitializeComponent();
            MainFormm = _Mainform;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainFormm.Idtextbox.Text = Idtextbox.Text;
            MainFormm.PassTextbox.Text = PassTextbox.Text;
            Close();
        }
    }
}
