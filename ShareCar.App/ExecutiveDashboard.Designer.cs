
namespace ShareCar.App
{
    partial class ExecutiveDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtExecutiveAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.exeGrid = new MetroFramework.Controls.MetroGrid();
            this.CarNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSeatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCS = new System.Windows.Forms.Button();
            this.btninactive = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exeGrid);
            this.panel1.Location = new System.Drawing.Point(17, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 236);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroTile1);
            this.panel2.Controls.Add(this.btninactive);
            this.panel2.Controls.Add(this.btnCS);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtExecutiveAutoSearch);
            this.panel2.Location = new System.Drawing.Point(17, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 59);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(567, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(68, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(501, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(425, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtExecutiveAutoSearch
            // 
            // 
            // 
            // 
            this.txtExecutiveAutoSearch.CustomButton.Image = null;
            this.txtExecutiveAutoSearch.CustomButton.Location = new System.Drawing.Point(80, 2);
            this.txtExecutiveAutoSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExecutiveAutoSearch.CustomButton.Name = "";
            this.txtExecutiveAutoSearch.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtExecutiveAutoSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExecutiveAutoSearch.CustomButton.TabIndex = 1;
            this.txtExecutiveAutoSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExecutiveAutoSearch.CustomButton.UseSelectable = true;
            this.txtExecutiveAutoSearch.CustomButton.Visible = false;
            this.txtExecutiveAutoSearch.Lines = new string[0];
            this.txtExecutiveAutoSearch.Location = new System.Drawing.Point(14, 13);
            this.txtExecutiveAutoSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExecutiveAutoSearch.MaxLength = 32767;
            this.txtExecutiveAutoSearch.Multiline = true;
            this.txtExecutiveAutoSearch.Name = "txtExecutiveAutoSearch";
            this.txtExecutiveAutoSearch.PasswordChar = '\0';
            this.txtExecutiveAutoSearch.PromptText = "Search As Driver";
            this.txtExecutiveAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExecutiveAutoSearch.SelectedText = "";
            this.txtExecutiveAutoSearch.SelectionLength = 0;
            this.txtExecutiveAutoSearch.SelectionStart = 0;
            this.txtExecutiveAutoSearch.ShortcutsEnabled = true;
            this.txtExecutiveAutoSearch.Size = new System.Drawing.Size(114, 36);
            this.txtExecutiveAutoSearch.TabIndex = 0;
            this.txtExecutiveAutoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExecutiveAutoSearch.UseSelectable = true;
            this.txtExecutiveAutoSearch.WaterMark = "Search As Driver";
            this.txtExecutiveAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExecutiveAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtExecutiveAutoSearch.TextChanged += new System.EventHandler(this.txtExecutiveAutoSearch_TextChanged);
            // 
            // exeGrid
            // 
            this.exeGrid.AllowUserToAddRows = false;
            this.exeGrid.AllowUserToDeleteRows = false;
            this.exeGrid.AllowUserToResizeRows = false;
            this.exeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.exeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.exeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarNumber,
            this.CarSeatNumber,
            this.DriverName,
            this.DriverCN,
            this.CarStatus});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.exeGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.exeGrid.EnableHeadersVisualStyles = false;
            this.exeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exeGrid.Location = new System.Drawing.Point(3, 3);
            this.exeGrid.Name = "exeGrid";
            this.exeGrid.ReadOnly = true;
            this.exeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.exeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.exeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exeGrid.Size = new System.Drawing.Size(638, 230);
            this.exeGrid.TabIndex = 0;
            // 
            // CarNumber
            // 
            this.CarNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarNumber.DataPropertyName = "CarNumber";
            this.CarNumber.HeaderText = "Car Number";
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.ReadOnly = true;
            // 
            // CarSeatNumber
            // 
            this.CarSeatNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarSeatNumber.DataPropertyName = "CarSeatNumber";
            this.CarSeatNumber.HeaderText = "Car Seat Number";
            this.CarSeatNumber.Name = "CarSeatNumber";
            this.CarSeatNumber.ReadOnly = true;
            // 
            // DriverName
            // 
            this.DriverName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "Driver Name";
            this.DriverName.Name = "DriverName";
            this.DriverName.ReadOnly = true;
            // 
            // DriverCN
            // 
            this.DriverCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DriverCN.DataPropertyName = "DriverCN";
            this.DriverCN.HeaderText = "Driver Contact Number";
            this.DriverCN.Name = "DriverCN";
            this.DriverCN.ReadOnly = true;
            // 
            // CarStatus
            // 
            this.CarStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarStatus.DataPropertyName = "CarStatus";
            this.CarStatus.HeaderText = "Car Status";
            this.CarStatus.Name = "CarStatus";
            this.CarStatus.ReadOnly = true;
            // 
            // btnCS
            // 
            this.btnCS.Location = new System.Drawing.Point(334, 13);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(86, 36);
            this.btnCS.TabIndex = 4;
            this.btnCS.Text = "Status Active";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btninactive
            // 
            this.btninactive.Location = new System.Drawing.Point(253, 13);
            this.btninactive.Name = "btninactive";
            this.btninactive.Size = new System.Drawing.Size(75, 36);
            this.btninactive.TabIndex = 5;
            this.btninactive.Text = "Satus Inactive";
            this.btninactive.UseVisualStyleBackColor = true;
            this.btninactive.Click += new System.EventHandler(this.btninactive_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(133, 13);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(114, 36);
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Active Request";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ExecutiveDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExecutiveDashboard";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "ExecutiveDashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private MetroFramework.Controls.MetroTextBox txtExecutiveAutoSearch;
        private MetroFramework.Controls.MetroGrid exeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSeatNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarStatus;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btninactive;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}