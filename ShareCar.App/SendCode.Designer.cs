
namespace ShareCar.App
{
    partial class SendCode
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
            this.pnlSendCode = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSendVerifyCode = new MetroFramework.Controls.MetroTextBox();
            this.txtSendEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSendCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSendCode
            // 
            this.pnlSendCode.BackColor = System.Drawing.Color.Crimson;
            this.pnlSendCode.Controls.Add(this.label3);
            this.pnlSendCode.Controls.Add(this.txtSendVerifyCode);
            this.pnlSendCode.Controls.Add(this.txtSendEmail);
            this.pnlSendCode.Controls.Add(this.btnSendCode);
            this.pnlSendCode.Controls.Add(this.btnSendEmail);
            this.pnlSendCode.Controls.Add(this.label2);
            this.pnlSendCode.Controls.Add(this.label1);
            this.pnlSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSendCode.Location = new System.Drawing.Point(17, 51);
            this.pnlSendCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSendCode.Name = "pnlSendCode";
            this.pnlSendCode.Size = new System.Drawing.Size(539, 141);
            this.pnlSendCode.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "OTP Code Verification Form";
            // 
            // txtSendVerifyCode
            // 
            // 
            // 
            // 
            this.txtSendVerifyCode.CustomButton.Image = null;
            this.txtSendVerifyCode.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtSendVerifyCode.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSendVerifyCode.CustomButton.Name = "";
            this.txtSendVerifyCode.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtSendVerifyCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSendVerifyCode.CustomButton.TabIndex = 1;
            this.txtSendVerifyCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSendVerifyCode.CustomButton.UseSelectable = true;
            this.txtSendVerifyCode.CustomButton.Visible = false;
            this.txtSendVerifyCode.Lines = new string[0];
            this.txtSendVerifyCode.Location = new System.Drawing.Point(152, 100);
            this.txtSendVerifyCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSendVerifyCode.MaxLength = 32767;
            this.txtSendVerifyCode.Name = "txtSendVerifyCode";
            this.txtSendVerifyCode.PasswordChar = '\0';
            this.txtSendVerifyCode.PromptText = "OTP Code";
            this.txtSendVerifyCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSendVerifyCode.SelectedText = "";
            this.txtSendVerifyCode.SelectionLength = 0;
            this.txtSendVerifyCode.SelectionStart = 0;
            this.txtSendVerifyCode.ShortcutsEnabled = true;
            this.txtSendVerifyCode.Size = new System.Drawing.Size(252, 19);
            this.txtSendVerifyCode.TabIndex = 7;
            this.txtSendVerifyCode.UseSelectable = true;
            this.txtSendVerifyCode.WaterMark = "OTP Code";
            this.txtSendVerifyCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSendVerifyCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSendEmail
            // 
            // 
            // 
            // 
            this.txtSendEmail.CustomButton.Image = null;
            this.txtSendEmail.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtSendEmail.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSendEmail.CustomButton.Name = "";
            this.txtSendEmail.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtSendEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSendEmail.CustomButton.TabIndex = 1;
            this.txtSendEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSendEmail.CustomButton.UseSelectable = true;
            this.txtSendEmail.CustomButton.Visible = false;
            this.txtSendEmail.Lines = new string[0];
            this.txtSendEmail.Location = new System.Drawing.Point(152, 56);
            this.txtSendEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSendEmail.MaxLength = 32767;
            this.txtSendEmail.Name = "txtSendEmail";
            this.txtSendEmail.PasswordChar = '\0';
            this.txtSendEmail.PromptText = "User email";
            this.txtSendEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSendEmail.SelectedText = "";
            this.txtSendEmail.SelectionLength = 0;
            this.txtSendEmail.SelectionStart = 0;
            this.txtSendEmail.ShortcutsEnabled = true;
            this.txtSendEmail.Size = new System.Drawing.Size(252, 19);
            this.txtSendEmail.TabIndex = 6;
            this.txtSendEmail.UseSelectable = true;
            this.txtSendEmail.WaterMark = "User email";
            this.txtSendEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSendEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(420, 96);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(95, 25);
            this.btnSendCode.TabIndex = 5;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(420, 54);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(95, 26);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter verify code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your email";
            // 
            // SendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 205);
            this.Controls.Add(this.pnlSendCode);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SendCode";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Send Code Form";
            this.pnlSendCode.ResumeLayout(false);
            this.pnlSendCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSendCode;
        private MetroFramework.Controls.MetroTextBox txtSendEmail;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtSendVerifyCode;
        private System.Windows.Forms.Label label3;
    }
}