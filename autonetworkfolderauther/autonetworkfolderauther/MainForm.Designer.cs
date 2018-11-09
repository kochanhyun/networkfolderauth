namespace autonetworkfolderauther
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlButton = new System.Windows.Forms.Button();
            this.FolderPathView = new System.Windows.Forms.TextBox();
            this.FolderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PassButton = new System.Windows.Forms.Button();
            this.ShareFolderAddButton = new System.Windows.Forms.Button();
            this.FolderPathText = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.PassTextbox = new System.Windows.Forms.TextBox();
            this.Idtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShareFolderNameTextbox = new System.Windows.Forms.TextBox();
            this.Readrb = new System.Windows.Forms.RadioButton();
            this.Readnwriterb = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlButton
            // 
            this.ControlButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlButton.Location = new System.Drawing.Point(3, 3);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(90, 60);
            this.ControlButton.TabIndex = 0;
            this.ControlButton.Text = "제어판 설정";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // FolderPathView
            // 
            this.FolderPathView.Location = new System.Drawing.Point(167, 105);
            this.FolderPathView.Name = "FolderPathView";
            this.FolderPathView.ReadOnly = true;
            this.FolderPathView.Size = new System.Drawing.Size(177, 21);
            this.FolderPathView.TabIndex = 1;
            // 
            // FolderButton
            // 
            this.FolderButton.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FolderButton.Location = new System.Drawing.Point(99, 3);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(90, 60);
            this.FolderButton.TabIndex = 2;
            this.FolderButton.Text = "폴더 지정";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ControlButton);
            this.flowLayoutPanel1.Controls.Add(this.FolderButton);
            this.flowLayoutPanel1.Controls.Add(this.PassButton);
            this.flowLayoutPanel1.Controls.Add(this.ShareFolderAddButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 67);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // PassButton
            // 
            this.PassButton.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.PassButton.Location = new System.Drawing.Point(195, 3);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(90, 60);
            this.PassButton.TabIndex = 3;
            this.PassButton.Text = "계정 지정";
            this.PassButton.UseVisualStyleBackColor = true;
            this.PassButton.Click += new System.EventHandler(this.PassButton_Click);
            // 
            // ShareFolderAddButton
            // 
            this.ShareFolderAddButton.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ShareFolderAddButton.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ShareFolderAddButton.Location = new System.Drawing.Point(291, 3);
            this.ShareFolderAddButton.Name = "ShareFolderAddButton";
            this.ShareFolderAddButton.Size = new System.Drawing.Size(90, 60);
            this.ShareFolderAddButton.TabIndex = 4;
            this.ShareFolderAddButton.Text = "공유 폴더\r\n생성";
            this.ShareFolderAddButton.UseVisualStyleBackColor = true;
            this.ShareFolderAddButton.Click += new System.EventHandler(this.ShareFolderAddButton_Click);
            // 
            // FolderPathText
            // 
            this.FolderPathText.AutoSize = true;
            this.FolderPathText.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FolderPathText.Location = new System.Drawing.Point(54, 107);
            this.FolderPathText.Name = "FolderPathText";
            this.FolderPathText.Size = new System.Drawing.Size(59, 15);
            this.FolderPathText.TabIndex = 4;
            this.FolderPathText.Text = "대상 폴더";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(52, 178);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(62, 12);
            this.password.TabIndex = 8;
            this.password.Text = "Password";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(75, 144);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 12);
            this.id.TabIndex = 7;
            this.id.Text = "ID";
            // 
            // PassTextbox
            // 
            this.PassTextbox.Location = new System.Drawing.Point(167, 173);
            this.PassTextbox.Name = "PassTextbox";
            this.PassTextbox.ReadOnly = true;
            this.PassTextbox.Size = new System.Drawing.Size(177, 21);
            this.PassTextbox.TabIndex = 6;
            this.PassTextbox.UseSystemPasswordChar = true;
            // 
            // Idtextbox
            // 
            this.Idtextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.Idtextbox.Location = new System.Drawing.Point(167, 140);
            this.Idtextbox.Name = "Idtextbox";
            this.Idtextbox.ReadOnly = true;
            this.Idtextbox.Size = new System.Drawing.Size(177, 21);
            this.Idtextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label1.Location = new System.Drawing.Point(66, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "권한";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label2.Location = new System.Drawing.Point(53, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "공유 이름";
            // 
            // ShareFolderNameTextbox
            // 
            this.ShareFolderNameTextbox.Location = new System.Drawing.Point(167, 242);
            this.ShareFolderNameTextbox.Name = "ShareFolderNameTextbox";
            this.ShareFolderNameTextbox.Size = new System.Drawing.Size(177, 21);
            this.ShareFolderNameTextbox.TabIndex = 12;
            // 
            // Readrb
            // 
            this.Readrb.AutoSize = true;
            this.Readrb.Location = new System.Drawing.Point(168, 211);
            this.Readrb.Name = "Readrb";
            this.Readrb.Size = new System.Drawing.Size(47, 16);
            this.Readrb.TabIndex = 14;
            this.Readrb.TabStop = true;
            this.Readrb.Text = "읽기";
            this.Readrb.UseVisualStyleBackColor = true;
            // 
            // Readnwriterb
            // 
            this.Readnwriterb.AutoSize = true;
            this.Readnwriterb.Location = new System.Drawing.Point(272, 211);
            this.Readnwriterb.Name = "Readnwriterb";
            this.Readnwriterb.Size = new System.Drawing.Size(77, 16);
            this.Readnwriterb.TabIndex = 15;
            this.Readnwriterb.TabStop = true;
            this.Readnwriterb.Text = "읽기/쓰기";
            this.Readnwriterb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(408, 330);
            this.Controls.Add(this.Readnwriterb);
            this.Controls.Add(this.Readrb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShareFolderNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.Controls.Add(this.PassTextbox);
            this.Controls.Add(this.Idtextbox);
            this.Controls.Add(this.FolderPathText);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.FolderPathView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "네트워크 폴더 암호 생성기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.TextBox FolderPathView;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label FolderPathText;
        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label id;
        internal System.Windows.Forms.TextBox Idtextbox;
        internal System.Windows.Forms.TextBox PassTextbox;
        private System.Windows.Forms.Button ShareFolderAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ShareFolderNameTextbox;
        private System.Windows.Forms.RadioButton Readrb;
        private System.Windows.Forms.RadioButton Readnwriterb;
    }
}

