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
            this.FolderPathText = new System.Windows.Forms.Label();
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
            this.FolderPathView.Location = new System.Drawing.Point(88, 105);
            this.FolderPathView.Name = "FolderPathView";
            this.FolderPathView.ReadOnly = true;
            this.FolderPathView.Size = new System.Drawing.Size(200, 21);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(707, 67);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // PassButton
            // 
            this.PassButton.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.PassButton.Location = new System.Drawing.Point(195, 3);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(90, 60);
            this.PassButton.TabIndex = 3;
            this.PassButton.Text = "암호 지정";
            this.PassButton.UseVisualStyleBackColor = true;
            // 
            // FolderPathText
            // 
            this.FolderPathText.AutoSize = true;
            this.FolderPathText.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FolderPathText.Location = new System.Drawing.Point(18, 107);
            this.FolderPathText.Name = "FolderPathText";
            this.FolderPathText.Size = new System.Drawing.Size(59, 15);
            this.FolderPathText.TabIndex = 4;
            this.FolderPathText.Text = "대상 폴더";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(731, 330);
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
    }
}

