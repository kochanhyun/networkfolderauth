namespace autonetworkfolderauther
{
    partial class ControlForm
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
            this.Help = new System.Windows.Forms.Label();
            this.ControlOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(12, 15);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(299, 120);
            this.Help.TabIndex = 2;
            this.Help.Text = "좌측의 설정 열기 버튼을 클릭 후\r\n\r\n네트워크 검색 켜기\r\n파일 및 프린터 공유 켜기\r\n암호 보호 공유 켜기\r\n사용자의 계정 및 암호를 사용하여" +
    " 다른 컴퓨터에 연결\r\n\r\n을 모두 활성화 해주시기 바랍니다.\r\n";
            this.Help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlOpenButton
            // 
            this.ControlOpenButton.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ControlOpenButton.Location = new System.Drawing.Point(98, 151);
            this.ControlOpenButton.Name = "ControlOpenButton";
            this.ControlOpenButton.Size = new System.Drawing.Size(120, 45);
            this.ControlOpenButton.TabIndex = 3;
            this.ControlOpenButton.Text = "설정 열기";
            this.ControlOpenButton.UseVisualStyleBackColor = true;
            this.ControlOpenButton.Click += new System.EventHandler(this.ControlOpenButton_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(325, 208);
            this.Controls.Add(this.ControlOpenButton);
            this.Controls.Add(this.Help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ControlForm";
            this.Text = "제어판 설정";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Button ControlOpenButton;
    }
}