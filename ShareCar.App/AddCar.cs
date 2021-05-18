using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ShareCar.Data;

namespace ShareCar.App
{
    public partial class AddCar : MetroForm
    {
        DataAccess DT { get; set; }
        public AddCar()
        {
            InitializeComponent();
            this.DT = new DataAccess();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtCarNumber.Text == "")
            {
                MessageBox.Show("Car Number required!", "Add Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.txtCarSC.Text == "")
            {
                MessageBox.Show("Car Seat Number required!", "Add validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.txtDCN.Text == "")
            {
                MessageBox.Show("Driver Phone number required!", "Add validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                string sql = "INSERT into CarStatus (CarNumber,CarSeatNumber,CarStatus,DriverName,DriverCN) values ('" + txtCarNumber.Text + "','" + txtCarSC.Text + "','" + txtStatus.Text + "','" + txtDriverName.Text + "','" + txtDCN.Text + " ') ";
                int count = this.DT.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Request add Successful");
                    ExecutiveDashboard executiveDashboard = new ExecutiveDashboard();
                    executiveDashboard.Show();
                    //this.Hide();
                    this.Visible = false;
                }
                else
                    MessageBox.Show("Request add Failed!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
