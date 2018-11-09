namespace autonetworkfolderauther
{
    partial class PasswordForm
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
            this.Idtextbox = new System.Windows.Forms.TextBox();
            this.PassTextbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Idtextbox
            // 
            this.Idtextbox.Location = new System.Drawing.Point(109, 106);
            this.Idtextbox.Name = "Idtextbox";
            this.Idtextbox.Size = new System.Drawing.Size(166, 21);
            this.Idtextbox.TabIndex = 0;
            // 
            // PassTextbox
            // 
            this.PassTextbox.Location = new System.Drawing.Point(109, 139);
            this.PassTextbox.Name = "PassTextbox";
            this.PassTextbox.Size = new System.Drawing.Size(166, 21);
            this.PassTextbox.TabIndex = 1;
            this.PassTextbox.UseSystemPasswordChar = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.AddButton.Location = new System.Drawing.Point(105, 190);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 49);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "생성";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(46, 110);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 12);
            this.id.TabIndex = 3;
            this.id.Text = "ID";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(24, 144);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(62, 12);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.help.Location = new System.Drawing.Point(45, 38);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(206, 30);
            this.help.TabIndex = 5;
            this.help.Text = "윈도우 계정을 생성합니다.\r\n이미 있는 ID를 입력하지 말아주세요.";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(304, 279);
            this.Controls.Add(this.help);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PassTextbox);
            this.Controls.Add(this.Idtextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PasswordForm";
            this.Text = "암호 지정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Idtextbox;
        private System.Windows.Forms.TextBox PassTextbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label help;
    }
}