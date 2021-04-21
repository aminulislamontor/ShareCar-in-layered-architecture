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
using System.Data.SqlClient;
using System.Data.Sql;
using ShareCar.Data;

namespace ShareCar.App
{
    public partial class ConfirmPassword : MetroForm
    {
        private DataAccess DA { get; set; }
        string userEmail = SendCode.to;

        public ConfirmPassword()
        {
            InitializeComponent();
            this.DA = new DataAccess();
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (this.txtNewPassword.Text == this.txtConfirmPassword.Text)
            {
                string query= "UPDATE UserInformation set Password = '" + this.txtConfirmPassword.Text +"' where UserMail = '" + this.userEmail + "'; ";
                
                
                int count = this.DA.ExecuteDML(query);
                if (count == 1)
                {
                    MessageBox.Show("Change");
                }
                else
                {
                    MessageBox.Show("Can not change");
                }
            }

            else
            {
                MessageBox.Show("Can't match with the new password");
            }
        }




        private void GridView(string sql="select * from UserInformation") 
        {
            try
            {
                DataSet ds = this.DA.ExecuteQuery(sql);
                this.dgvUser.AutoGenerateColumns = false;
                this.dgvUser.DataSource = ds.Tables[0];
            }
            catch (Exception exc) 
            {
                MessageBox.Show("Erroe: "+exc.Message);
            }
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            this.GridView();
        }
    }
}
