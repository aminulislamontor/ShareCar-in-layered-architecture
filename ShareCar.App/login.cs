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
        public login()
        {
            InitializeComponent();
            this.DA = new DataAccess();
        }

        private DataAccess DA { get; set; }

        //Thread th;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select * from UserInformation where 
                              UserName = '" + this.txtUserName.Text + "' and " +
                              "Password = '" + this.txtPassword.Text + "';  ";

                var ds = this.DA.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                    MessageBox.Show("Signin successful");
                else
                    MessageBox.Show("Signin failed");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            /* th = new Thread(OpenNewForm);
             th.SetApartmentState(ApartmentState.STA);
             th.Start();
             this.Close();*/
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

    }
}
