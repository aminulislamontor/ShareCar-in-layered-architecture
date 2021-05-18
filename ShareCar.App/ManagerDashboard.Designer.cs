
namespace ShareCar.App
{
    partial class ManagerDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRequestCarApproval = new System.Windows.Forms.Button();
            this.Com = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCarRequest = new System.Windows.Forms.DataGridView();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSeatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDriverCN = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtCarStatus = new System.Windows.Forms.TextBox();
            this.txtCarSeatNumber = new System.Windows.Forms.TextBox();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCarAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Com.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRequest)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.deleteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(107, 22);
            this.menuSave.Text = "Save";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAllUsers);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnRequestCarApproval);
            this.panel1.Controls.Add(this.Com);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 429);
            this.panel1.TabIndex = 5;
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.Location = new System.Drawing.Point(2, 137);
            this.btnAllUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(160, 69);
            this.btnAllUsers.TabIndex = 4;
            this.btnAllUsers.Text = "All Users";
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(2, 213);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 64);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRequestCarApproval
            // 
            this.btnRequestCarApproval.Location = new System.Drawing.Point(2, 71);
            this.btnRequestCarApproval.Margin = new System.Windows.Forms.Padding(2);
            this.btnRequestCarApproval.Name = "btnRequestCarApproval";
            this.btnRequestCarApproval.Size = new System.Drawing.Size(160, 62);
            this.btnRequestCarApproval.TabIndex = 1;
            this.btnRequestCarApproval.Text = "Request Car Approval";
            this.btnRequestCarApproval.UseVisualStyleBackColor = true;
            this.btnRequestCarApproval.Click += new System.EventHandler(this.btnRequestCarApproval_Click);
            // 
            // Com
            // 
            this.Com.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Com.Controls.Add(this.label1);
            this.Com.Location = new System.Drawing.Point(2, 10);
            this.Com.Margin = new System.Windows.Forms.Padding(2);
            this.Com.Name = "Com";
            this.Com.Size = new System.Drawing.Size(160, 53);
            this.Com.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // dgvCarRequest
            // 
            this.dgvCarRequest.AllowUserToAddRows = false;
            this.dgvCarRequest.AllowUserToDeleteRows = false;
            this.dgvCarRequest.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCarRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverName,
            this.DriverCN,
            this.CarNumber,
            this.CarSeatNumber,
            this.CarStatus});
            this.dgvCarRequest.Location = new System.Drawing.Point(2, 0);
            this.dgvCarRequest.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCarRequest.Name = "dgvCarRequest";
            this.dgvCarRequest.ReadOnly = true;
            this.dgvCarRequest.RowHeadersWidth = 51;
            this.dgvCarRequest.RowTemplate.Height = 24;
            this.dgvCarRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarRequest.Size = new System.Drawing.Size(534, 196);
            this.dgvCarRequest.TabIndex = 0;
            this.dgvCarRequest.DoubleClick += new System.EventHandler(this.dgvCarRequest_DoubleClick);
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "Driver Name";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // DriverCN
            // 
            this.DriverCN.DataPropertyName = "DriverCN";
            this.DriverCN.HeaderText = "Driver Phone Number";
            this.DriverCN.Name = "DriverCN";
            this.DriverCN.ReadOnly = true;
            // 
            // CarNumber
            // 
            this.CarNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarNumber.DataPropertyName = "CarNumber";
            this.CarNumber.HeaderText = "Car Number";
            this.CarNumber.MinimumWidth = 6;
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.ReadOnly = true;
            // 
            // CarSeatNumber
            // 
            this.CarSeatNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarSeatNumber.DataPropertyName = "CarSeatNumber";
            this.CarSeatNumber.HeaderText = "Car Seat Number";
            this.CarSeatNumber.MinimumWidth = 6;
            this.CarSeatNumber.Name = "CarSeatNumber";
            this.CarSeatNumber.ReadOnly = true;
            // 
            // CarStatus
            // 
            this.CarStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarStatus.DataPropertyName = "CarStatus";
            this.CarStatus.HeaderText = "Car Status";
            this.CarStatus.MinimumWidth = 6;
            this.CarStatus.Name = "CarStatus";
            this.CarStatus.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Information";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvCarRequest);
            this.panel4.Location = new System.Drawing.Point(192, 317);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 196);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(190, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 44);
            this.panel2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 12);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDriverCN);
            this.panel3.Controls.Add(this.txtDriverName);
            this.panel3.Controls.Add(this.txtCarStatus);
            this.panel3.Controls.Add(this.txtCarSeatNumber);
            this.panel3.Controls.Add(this.txtCarNumber);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(192, 153);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 160);
            this.panel3.TabIndex = 10;
            // 
            // txtDriverCN
            // 
            this.txtDriverCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverCN.Location = new System.Drawing.Point(104, 117);
            this.txtDriverCN.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriverCN.Name = "txtDriverCN";
            this.txtDriverCN.Size = new System.Drawing.Size(128, 26);
            this.txtDriverCN.TabIndex = 5;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName.Location = new System.Drawing.Point(104, 87);
            this.txtDriverName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(128, 26);
            this.txtDriverName.TabIndex = 5;
            // 
            // txtCarStatus
            // 
            this.txtCarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarStatus.Location = new System.Drawing.Point(104, 57);
            this.txtCarStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarStatus.Name = "txtCarStatus";
            this.txtCarStatus.Size = new System.Drawing.Size(128, 26);
            this.txtCarStatus.TabIndex = 5;
            // 
            // txtCarSeatNumber
            // 
            this.txtCarSeatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarSeatNumber.Location = new System.Drawing.Point(104, 34);
            this.txtCarSeatNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarSeatNumber.Name = "txtCarSeatNumber";
            this.txtCarSeatNumber.Size = new System.Drawing.Size(128, 26);
            this.txtCarSeatNumber.TabIndex = 4;
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarNumber.Location = new System.Drawing.Point(104, 11);
            this.txtCarNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(128, 26);
            this.txtCarNumber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Driver Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Driver Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Seat Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Car Number";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtCarAutoSearch);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Location = new System.Drawing.Point(451, 153);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 89);
            this.panel5.TabIndex = 11;
            // 
            // txtCarAutoSearch
            // 
            // 
            // 
            // 
            this.txtCarAutoSearch.CustomButton.Image = null;
            this.txtCarAutoSearch.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.txtCarAutoSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarAutoSearch.CustomButton.Name = "";
            this.txtCarAutoSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCarAutoSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCarAutoSearch.CustomButton.TabIndex = 1;
            this.txtCarAutoSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCarAutoSearch.CustomButton.UseSelectable = true;
            this.txtCarAutoSearch.CustomButton.Visible = false;
            this.txtCarAutoSearch.Lines = new string[0];
            this.txtCarAutoSearch.Location = new System.Drawing.Point(14, 54);
            this.txtCarAutoSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarAutoSearch.MaxLength = 32767;
            this.txtCarAutoSearch.Multiline = true;
            this.txtCarAutoSearch.Name = "txtCarAutoSearch";
            this.txtCarAutoSearch.PasswordChar = '\0';
            this.txtCarAutoSearch.PromptText = "Search by Driver Name";
            this.txtCarAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCarAutoSearch.SelectedText = "";
            this.txtCarAutoSearch.SelectionLength = 0;
            this.txtCarAutoSearch.SelectionStart = 0;
            this.txtCarAutoSearch.ShortcutsEnabled = true;
            this.txtCarAutoSearch.Size = new System.Drawing.Size(254, 28);
            this.txtCarAutoSearch.TabIndex = 3;
            this.txtCarAutoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCarAutoSearch.UseSelectable = true;
            this.txtCarAutoSearch.WaterMark = "Search by Driver Name";
            this.txtCarAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCarAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarAutoSearch.TextChanged += new System.EventHandler(this.txtCarAutoSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 37);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 529);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerDashboard";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "ManagerDashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Com.ResumeLayout(false);
            this.Com.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRequest)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRequestCarApproval;
        private System.Windows.Forms.Panel Com;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.DataGridView dgvCarRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCarStatus;
        private System.Windows.Forms.TextBox txtCarSeatNumber;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroTextBox txtCarAutoSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSeatNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarStatus;
        private System.Windows.Forms.TextBox txtDriverCN;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}