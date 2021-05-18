
namespace ShareCar.App
{
    partial class UserDashboard
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
            this.dvgUserDashBoard = new System.Windows.Forms.DataGridView();
            this.CarRequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.txtUserSearch = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUserDashBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserSearch);
            this.panel1.Controls.Add(this.dvgUserDashBoard);
            this.panel1.Controls.Add(this.btnlogOut);
            this.panel1.Controls.Add(this.btnAddRequest);
            this.panel1.Location = new System.Drawing.Point(18, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 401);
            this.panel1.TabIndex = 0;
            // 
            // dvgUserDashBoard
            // 
            this.dvgUserDashBoard.AllowUserToAddRows = false;
            this.dvgUserDashBoard.AllowUserToDeleteRows = false;
            this.dvgUserDashBoard.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgUserDashBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUserDashBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarRequestId,
            this.Time,
            this.Reason,
            this.Address,
            this.Status});
            this.dvgUserDashBoard.Location = new System.Drawing.Point(0, 68);
            this.dvgUserDashBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgUserDashBoard.Name = "dvgUserDashBoard";
            this.dvgUserDashBoard.ReadOnly = true;
            this.dvgUserDashBoard.RowHeadersWidth = 51;
            this.dvgUserDashBoard.RowTemplate.Height = 24;
            this.dvgUserDashBoard.Size = new System.Drawing.Size(800, 333);
            this.dvgUserDashBoard.TabIndex = 10;
            // 
            // CarRequestId
            // 
            this.CarRequestId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarRequestId.DataPropertyName = "CarRequestId";
            this.CarRequestId.HeaderText = "Car Request Id";
            this.CarRequestId.MinimumWidth = 6;
            this.CarRequestId.Name = "CarRequestId";
            this.CarRequestId.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.MinimumWidth = 6;
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnlogOut
            // 
            this.btnlogOut.Location = new System.Drawing.Point(692, 11);
            this.btnlogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(97, 41);
            this.btnlogOut.TabIndex = 9;
            this.btnlogOut.Text = "LogOut";
            this.btnlogOut.UseVisualStyleBackColor = true;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(578, 11);
            this.btnAddRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(95, 41);
            this.btnAddRequest.TabIndex = 8;
            this.btnAddRequest.Text = "AddRequest";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // txtUserSearch
            // 
            // 
            // 
            // 
            this.txtUserSearch.CustomButton.Image = null;
            this.txtUserSearch.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtUserSearch.CustomButton.Name = "";
            this.txtUserSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserSearch.CustomButton.TabIndex = 1;
            this.txtUserSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserSearch.CustomButton.UseSelectable = true;
            this.txtUserSearch.CustomButton.Visible = false;
            this.txtUserSearch.Lines = new string[0];
            this.txtUserSearch.Location = new System.Drawing.Point(118, 29);
            this.txtUserSearch.MaxLength = 32767;
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.PasswordChar = '\0';
            this.txtUserSearch.PromptText = "Search by Address";
            this.txtUserSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserSearch.SelectedText = "";
            this.txtUserSearch.SelectionLength = 0;
            this.txtUserSearch.SelectionStart = 0;
            this.txtUserSearch.ShortcutsEnabled = true;
            this.txtUserSearch.Size = new System.Drawing.Size(169, 23);
            this.txtUserSearch.TabIndex = 12;
            this.txtUserSearch.UseSelectable = true;
            this.txtUserSearch.WaterMark = "Search by Address";
            this.txtUserSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserSearch.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 464);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserDashboard";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUserDashBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.DataGridView dvgUserDashBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MetroFramework.Controls.MetroTextBox txtUserSearch;
    }
}