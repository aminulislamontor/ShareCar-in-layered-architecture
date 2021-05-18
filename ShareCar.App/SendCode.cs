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
using System.Net;
using System.Net.Mail;

namespace ShareCar.App
{
    public partial class SendCode : MetroForm
    {
        string otpCode;
        //public static string to;

        //public string OtpCode { get; set; }
        public static string to;

        public SendCode()
        {
            InitializeComponent();
        }


        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string from;  
            string pass; 
            string messageBody; 
            Random random = new Random();
            this.otpCode = (random.Next(999999)).ToString(); 
            MailMessage message = new MailMessage();
            to = (this.txtSendEmail.Text).ToString();
            from = "ikmaminul@gmail.com";  //mahbub@gmail.com
            pass = "DdD4z!K:nHjb7bF";  //password of the mail
            messageBody = "Your reset OTP code is : " + this.otpCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Forgot Password Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }


        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (this.otpCode == (this.txtSendVerifyCode.Text).ToString())
            {
                to = this.txtSendEmail.Text;
                ConfirmPassword changePassword = new ConfirmPassword();
                this.Visible = false;
                changePassword.Show();
            }
            else
            {
                MessageBox.Show("Wrong verify code");
            }

        }

       
    }
}


