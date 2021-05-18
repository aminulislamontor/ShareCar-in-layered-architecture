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
using System.Threading;

namespace ShareCar.App
{

    public partial class login : MetroForm
    {
        DataAccess DA { get; set; }

        public login()
        {
            InitializeComponent();
            this.DA = new DataAccess();
        }




        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            SendCode sendCode = new SendCode();
            sendCode.Show();
        }

        private void btnLoginClear_Click(object sender, EventArgs e)
        {
            this.txtUserName.Text = "";
            this.txtPassword.Clear();
        }





        bool ManagerLogin() 
        {
            
            string c = "Manager";
            string sql = @"select * from UserTbl where 
                              UserName = '" + this.txtUserName.Text + "' and " +
                            "UserPassword = '" + this.txtPassword.Text + "' and UserType='"+c+"';  ";
            var ds = this.DA.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                //MessageBox.Show("Signin successful");
                return true;
            }
            else
            {
                //MessageBox.Show("Signin failed");
                return false;
            }
        }
        
        bool ExecutiveLogin() 
        {
            
            string d = "Executive";
            string sql = @"select * from UserTbl where 
                              UserName = '" + this.txtUserName.Text + "' and " +
                            "UserPassword = '" + this.txtPassword.Text + "' and UserType='" + d + "';  ";
            var ds = this.DA.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                //MessageBox.Show("Signin successful");
                return true;
            }
            else
            {
                //MessageBox.Show("Signin failed");
                return false;
            }
        }
        
        bool UserLogin() 
        {
            
            string e = "User";
            string sql = @"select * from UserTbl where 
                              UserName = '" + this.txtUserName.Text + "' and " +
                            "UserPassword = '" + this.txtPassword.Text + "' and UserType='" + e + "';  ";
            var ds = this.DA.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                //MessageBox.Show("Signin successful");
                return true;
            }
            else
            {
                //MessageBox.Show("Signin failed");
                return false;
            }
        }

        public static string user;
        public string UserName()
        {
            user = username1;
            return username1;
        }


        

        public static string username1;

        private void btnLogin_Click(object sender, EventArgs e) 
        {
            username1 = txtUserName.Text;
            bool manager=ManagerLogin();
            bool executive=ExecutiveLogin();
            bool user=UserLogin();

            if (manager == true)
            {
                MessageBox.Show("Login Successful admin");
                this.Hide();
                ManagerDashboard management = new ManagerDashboard();
                management.Show();
                this.Hide();
            }
            else if (executive == true)
            {
                
                MessageBox.Show("Login Successful executive");
                this.Hide();
                ExecutiveDashboard dashboard = new ExecutiveDashboard();
                dashboard.Show();
            }
            else if (user == true)
            {
                MessageBox.Show("Login Successful User");
                this.Hide();
                UserDashboard exedashboard = new UserDashboard();
                exedashboard.Show();
            }
            else
                MessageBox.Show("Login Failed!", "Login Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void TileClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
