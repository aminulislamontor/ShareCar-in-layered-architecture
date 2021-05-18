using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareCar.Data;
using MetroFramework.Forms;

namespace ShareCar.App
{
    public partial class ExecutiveDashboard : MetroForm
    {
        private DataAccess Da { get; set; }
        public ExecutiveDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulatedCarGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCar add = new AddCar();
            this.Visible = false;
            add.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Close();
            lg.Show();
        }

        private void PopulatedCarGridView(string query = "select * from CarStatus")
        {
            DataSet dataSet = this.Da.ExecuteQuery(query);
            this.exeGrid.AutoGenerateColumns = false;
            this.exeGrid.DataSource = dataSet.Tables[0];
            this.exeGrid.ClearSelection();
            this.exeGrid.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var carNumber = this.exeGrid.CurrentRow.Cells["CarNumber"].Value.ToString();

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

        private void btnCS_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "Active";
                string carNumber = this.exeGrid.CurrentRow.Cells["CarNumber"].Value.ToString();
                string sql = "update CarStatus set CarStatus = '" + status + "' where CarNumber='" + carNumber + "'";
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
                this.PopulatedCarGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: ", exc.Message);
            }
        }

        private void btninactive_Click(object sender, EventArgs e)
        {
            string status = "Inactive";
            string carNumber = this.exeGrid.CurrentRow.Cells["CarNumber"].Value.ToString();
            string sql = "update CarStatus set CarStatus = '" + status + "' where CarNumber='" + carNumber + "'";
            int count = this.Da.ExecuteDML(sql);

            try
            {

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
                this.PopulatedCarGridView();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: ", exc.Message);
            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ActiveRequest activeRequest = new ActiveRequest();
            this.Visible = false;
            activeRequest.Show();
        }

        private void txtExecutiveAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from CarStatus where DriverName like'" + this.txtExecutiveAutoSearch.Text + "%';";
            this.PopulatedCarGridView(sql);
        }
    }
}

