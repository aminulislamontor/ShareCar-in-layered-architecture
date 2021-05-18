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
    public partial class CarRequest : MetroForm
    {
        string status = "Pending";
        DataAccess DA { get; set; }

        public CarRequest()
        {
            InitializeComponent();
            this.DA = new DataAccess();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (this.txtTime.Text == "")
            {
                MessageBox.Show("Time required!", "Add Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.txtReason.Text == "")
            {
                MessageBox.Show("Reason required!", "Add validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.txtAddress.Text == "")
            {
                MessageBox.Show("Address required!", "Add validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                login lg = new login();
                string userName = lg.UserName();

                // bool b = requestRepo.AddRequest(request, user);
                string sql = "INSERT into CarRequestApprove (Time,Reason,Address,Status,UserName) values ('" + this.txtTime.Text + "','" + this.txtReason.Text + "','" + this.txtAddress.Text + "','" + this.status + "','" + userName + " ') ";
                int count = this.DA.ExecuteDML(sql);

                if (count==1)
                {
                    MessageBox.Show("Request add Successful");
                    UserDashboard userDashboard = new UserDashboard();
                    userDashboard.Show();
                    //this.Hide();
                    this.Visible = false;
                }
                else
                    MessageBox.Show("Request add Failed!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
