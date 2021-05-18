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
    public partial class AllUsers : MetroForm
    {
        private DataAccess Da { get; set; }

        public AllUsers()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public void PopulatedGridView(string query = "select * from UserTbl") 
        {
            DataSet dataSet = this.Da.ExecuteQuery(query);
            this.dgvAllUsers.AutoGenerateColumns = false;
            this.dgvAllUsers.DataSource = dataSet.Tables[0];
        }


        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from UserTbl where UserName like'" + this.txtUserSearch.Text + "%';";
            this.PopulatedGridView(sql);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var userid = this.dgvAllUsers.CurrentRow.Cells["UserId"].Value.ToString();
                var userName = this.dgvAllUsers.CurrentRow.Cells[1].Value.ToString();

                //string sql = "delete from UserTbl where UserId='"+this.dgvAllUsers.CurrentRow.Cells[0]+"';";
                string sql = "delete from UserTbl where UserId='" + userid + "';";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show(userName + " user has been deleted");
                }
                else
                {
                    MessageBox.Show("Can not delet");
                }
                this.PopulatedGridView();
            }
            catch (Exception exc)
            {
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
