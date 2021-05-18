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
    public partial class UserDashboard : MetroForm
    {
        public static string username;
        private DataAccess Da { get; set; }

        public UserDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.UserPopulatedGridView();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CarRequest carRequest = new CarRequest();
            carRequest.Show();
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login lg = new login();
            lg.Show();
        }

        
               

        private void UserPopulatedGridView() 
        {
            login lg = new login();
            string userName = lg.UserName();

            string query = "select * from CarRequestApprove where UserName = '"+ userName + "';";
            DataSet dataSet = this.Da.ExecuteQuery(query);
            this.dvgUserDashBoard.AutoGenerateColumns = false;
            this.dvgUserDashBoard.DataSource = dataSet.Tables[0];
            this.dvgUserDashBoard.ClearSelection();
            this.dvgUserDashBoard.Refresh();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
           
            
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from CarRequestApprove where Address like'" + this.txtUserSearch.Text + "%';";
            this.UserPopulatedGridView();
        }
    }
}
