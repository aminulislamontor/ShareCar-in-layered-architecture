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
    public partial class CarRequestApprove : MetroForm
    {
        private DataAccess Da { get; set; }

        public CarRequestApprove()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.CarRequestPopulatedGridView();
        }

        public void CarRequestPopulatedGridView(string query = "select * from CarRequestApprove")
        {
            DataSet dataSet = this.Da.ExecuteQuery(query);
            this.dgvCarRequestApprove.AutoGenerateColumns = false;
            this.dgvCarRequestApprove.DataSource = dataSet.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from CarRequestApprove where UserName like'" + this.txtSearch.Text + "%';";
            this.CarRequestPopulatedGridView(sql);
        }

        private void ClearCarRequestContent()
        {
            
            this.txtSearch.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearCarRequestContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvCarRequestApprove.CurrentRow.Cells["UserId"].Value.ToString();

                string sql = "delete from CarRequestApprove where UserId='" + id + "';";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show(id + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Can not delet");
                }
                this.CarRequestPopulatedGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: ", exc.Message);
            }
        }

        private void dgvCarRequestApprove_DoubleClick(object sender, EventArgs e)
        {
            
        }
        string status = "Pending";
        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "Dactive";
                string carRequestId = this.dgvCarRequestApprove.CurrentRow.Cells["CarRequestId"].Value.ToString();
                string sql = "update CarRequestApprove set Status = '" + status + "' where CarRequestId='" + carRequestId + "'";
                int count = this.Da.ExecuteDML(sql);



                if (count == 1)
                {
                    MessageBox.Show("Request add Successful");
                }
                else
                {
                    MessageBox.Show("Request add Failed!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.CarRequestPopulatedGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: ", exc.Message);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "Active";
                string carRequestId = this.dgvCarRequestApprove.CurrentRow.Cells["CarRequestId"].Value.ToString();
                string sql = "update CarRequestApprove set Status = '" + status + "' where CarRequestId='" + carRequestId + "'";
                int count = this.Da.ExecuteDML(sql);



                if (count == 1)
                {
                    MessageBox.Show("Request add Successful");
                    //UserDashboard userDashboard = new UserDashboard();
                    //userDashboard.Show();
                    //this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Request add Failed!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.CarRequestPopulatedGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: ", exc.Message);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerDashboard md = new ManagerDashboard();
            md.Show();
            this.Visible = false;
        }
    }
}
