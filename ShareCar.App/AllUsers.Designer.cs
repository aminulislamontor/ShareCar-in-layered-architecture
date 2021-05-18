
namespace ShareCar.App
{
    partial class AllUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mmuStrpAllUser = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserSearch = new MetroFramework.Controls.MetroTextBox();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.panel2.SuspendLayout();
            this.mmuStrpAllUser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAllUsers);
            this.panel1.Location = new System.Drawing.Point(10, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 274);
            this.panel1.TabIndex = 0;
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserMail,
            this.UserPass,
            this.UserGender,
            this.UserAddress,
            this.UserType});
            this.dgvAllUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvAllUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.RowTemplate.Height = 24;
            this.dgvAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllUsers.Size = new System.Drawing.Size(833, 274);
            this.dgvAllUsers.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mmuStrpAllUser);
            this.panel2.Location = new System.Drawing.Point(10, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 24);
            this.panel2.TabIndex = 1;
            // 
            // mmuStrpAllUser
            // 
            this.mmuStrpAllUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mmuStrpAllUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mmuStrpAllUser.Location = new System.Drawing.Point(0, 0);
            this.mmuStrpAllUser.Name = "mmuStrpAllUser";
            this.mmuStrpAllUser.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mmuStrpAllUser.Size = new System.Drawing.Size(836, 24);
            this.mmuStrpAllUser.TabIndex = 0;
            this.mmuStrpAllUser.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "Delete";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUserSearch);
            this.panel3.Location = new System.Drawing.Point(10, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 50);
            this.panel3.TabIndex = 2;
            // 
            // txtUserSearch
            // 
            // 
            // 
            // 
            this.txtUserSearch.CustomButton.Image = null;
            this.txtUserSearch.CustomButton.Location = new System.Drawing.Point(586, 2);
            this.txtUserSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserSearch.CustomButton.Name = "";
            this.txtUserSearch.CustomButton.Size = new System.Drawing.Size(28, 30);
            this.txtUserSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserSearch.CustomButton.TabIndex = 1;
            this.txtUserSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserSearch.CustomButton.UseSelectable = true;
            this.txtUserSearch.CustomButton.Visible = false;
            this.txtUserSearch.Lines = new string[0];
            this.txtUserSearch.Location = new System.Drawing.Point(3, 5);
            this.txtUserSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserSearch.MaxLength = 32767;
            this.txtUserSearch.Multiline = true;
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.PasswordChar = '\0';
            this.txtUserSearch.PromptText = "Search";
            this.txtUserSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserSearch.SelectedText = "";
            this.txtUserSearch.SelectionLength = 0;
            this.txtUserSearch.SelectionStart = 0;
            this.txtUserSearch.ShortcutsEnabled = true;
            this.txtUserSearch.Size = new System.Drawing.Size(821, 42);
            this.txtUserSearch.TabIndex = 0;
            this.txtUserSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserSearch.UseSelectable = true;
            this.txtUserSearch.WaterMark = "Search";
            this.txtUserSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User Id";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserMail
            // 
            this.UserMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserMail.DataPropertyName = "UserMail";
            this.UserMail.HeaderText = "User Mail";
            this.UserMail.MinimumWidth = 6;
            this.UserMail.Name = "UserMail";
            this.UserMail.ReadOnly = true;
            // 
            // UserPass
            // 
            this.UserPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserPass.DataPropertyName = "UserPass";
            this.UserPass.HeaderText = "User Password";
            this.UserPass.MinimumWidth = 6;
            this.UserPass.Name = "UserPass";
            this.UserPass.ReadOnly = true;
            // 
            // UserGender
            // 
            this.UserGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserGender.DataPropertyName = "UserGender";
            this.UserGender.HeaderText = "User Gender";
            this.UserGender.MinimumWidth = 6;
            this.UserGender.Name = "UserGender";
            this.UserGender.ReadOnly = true;
            // 
            // UserAddress
            // 
            this.UserAddress.DataPropertyName = "UserAddress";
            this.UserAddress.HeaderText = "User Address";
            this.UserAddress.MinimumWidth = 6;
            this.UserAddress.Name = "UserAddress";
            this.UserAddress.ReadOnly = true;
            this.UserAddress.Width = 125;
            // 
            // UserType
            // 
            this.UserType.DataPropertyName = "UserType";
            this.UserType.HeaderText = "User Department";
            this.UserType.MinimumWidth = 6;
            this.UserType.Name = "UserType";
            this.UserType.ReadOnly = true;
            this.UserType.Width = 125;
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // AllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mmuStrpAllUser;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AllUsers";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "AllUsers";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mmuStrpAllUser.ResumeLayout(false);
            this.mmuStrpAllUser.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip mmuStrpAllUser;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox txtUserSearch;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}