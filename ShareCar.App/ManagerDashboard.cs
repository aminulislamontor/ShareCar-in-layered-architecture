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
using ShareCar.App;

namespace ShareCar.App
{
    public partial class ManagerDashboard : MetroForm
    {
        private DataAccess Da { get; set; }

        public ManagerDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulatedCarGridView();
        }


        //private void PopulatedCombinedGridView(string query = "select UserName, UserAddress,CarNumber, CarStatus from UserTbl, CarStatus")
        private void PopulatedCarGridView(string query = "select * from CarStatus")
        {
            DataSet dataSet = this.Da.ExecuteQuery(query);
            this.dgvCarRequest.AutoGenerateColumns = false;
            this.dgvCarRequest.DataSource = dataSet.Tables[0];
            this.dgvCarRequest.ClearSelection();
            this.dgvCarRequest.Refresh();
        }


        private void btnRequestCarApproval_Click(object sender, EventArgs e)
        {
            try 
            {
                CarRequestApprove carRequestApprove = new CarRequestApprove();
                carRequestApprove.Show();
                this.Visible = false;
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSignupRequestApproval_Click(object sender, EventArgs e)
        {
           
            
        }


       /* private void PopulatedGridView(string query = "select * from UserTbl")
        {
            DataSet dataSet = this.Da.ExecuteQuery(query);
            this.dgvCarRequest.AutoGenerateColumns = false;
            this.dgvCarRequest.DataSource = dataSet.Tables[0];

        } */
        
        
       

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            AllUsers au = new AllUsers();
            au.Show();
            au.PopulatedGridView();
            this.Visible = false;
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        private void dgvCarRequest_DoubleClick(object sender, EventArgs e)
        {
            this.txtCarNumber.Text= this.dgvCarRequest.CurrentRow.Cells["CarNumber"].Value.ToString();
            this.txtCarSeatNumber.Text= this.dgvCarRequest.CurrentRow.Cells["CarSeatNumber"].Value.ToString();
            this.txtCarStatus.Text= this.dgvCarRequest.CurrentRow.Cells["CarStatus"].Value.ToString();
            this.txtDriverName.Text = this.dgvCarRequest.CurrentRow.Cells["DriverName"].Value.ToString();
            this.txtDriverCN.Text = this.dgvCarRequest.CurrentRow.Cells["DriverCN"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtCarNumber.Text) || String.IsNullOrEmpty(this.txtCarSeatNumber.Text) || String.IsNullOrEmpty(this.txtCarStatus.Text))
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }


                // insert update operation
                var sql = "select * from CarStatus where CarNumber = '" + this.txtCarNumber.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    string query = "update CarStatus set CarNumber = '" + this.txtCarNumber.Text +
                        "', CarSeatNumber = '" + txtCarSeatNumber.Text + "', CarStatus = '" + this.txtCarStatus.Text +"';";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Can not update data");
                    }

                    this.PopulatedCarGridView();

                }
                else
                {
                    //insert
                    string query = " insert into CarStatus (CarNumber,CarSeatNumber,CarStatus,DriverName,DriverCN) values('" + this.txtCarNumber.Text + "', '" + this.txtCarSeatNumber.Text + "', '" + this.txtCarStatus.Text + "', '" + this.txtDriverName.Text + "', '" + this.txtDriverCN.Text + "'); ";
                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                        MessageBox.Show("Data inserted");
                    else
                        MessageBox.Show("Data dis not inserted");

                    this.PopulatedCarGridView();
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error : " + exc.Message);
            }

            this.ClearCarContent();
        }

        private void ClearCarContent()
        {
            this.txtCarNumber.Clear();
            this.txtCarSeatNumber.Clear();
            this.txtCarStatus.Clear();
            this.txtDriverCN.Clear();
            this.txtDriverName.Clear();
            this.txtCarAutoSearch.Text = "";
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var carNumber = this.dgvCarRequest.CurrentRow.Cells["CarNumber"].Value.ToString();

                string sql = "delete from CarStatus where CarNumber='" + carNumber + "';";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show(carNumber + " user has been deleted");
                }
                else
                {
                    MessageBox.Show("Can not delet");
                }
                this.PopulatedCarGridView();
            }
            catch (Exception exc) 
            {
                MessageBox.Show("Error",exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearCarContent();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var carNumber = this.dgvCarRequest.CurrentRow.Cells["CarNumber"].Value.ToString();

                string sql = "delete from CarStatus where CarNumber='" + carNumber + "';";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show(carNumber + " user has been deleted");
                }
                else
                {
                    MessageBox.Show("Can not delet");
                }
                this.PopulatedCarGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error", exc.Message);
            }
        }

        

        private void txtCarAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from CarStatus where DriverName like'" + this.txtCarAutoSearch.Text + "%';";
            this.PopulatedCarGridView(sql);
        }
    }
}