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
        //string otpCode;
        //public static string to;

        public string OtpCode { get; set; }
        public static string to;

        public SendCode()
        {
            InitializeComponent();
        }


        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string from;  // for mail. Jei mail theke user mail e varification code send hobe
            string pass;  // mail er password
            string messageBody; // holding otp code
            Random random = new Random();
            this.OtpCode = (random.Next(999999)).ToString();  // 6 digits random number
            MailMessage message = new MailMessage();
            to = (this.txtSendEmail.Text).ToString();
            from = "";  // you have to give an email id like "mahabub@gmail.com";
            pass = ""; // have to give the password
            messageBody = "Your reset OTP code is : " + this.OtpCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Forgot Password Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            // ei gula aktu google theke study korte hobe
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
            if (this.OtpCode == (this.txtSendVerifyCode.Text).ToString())
            {
                to = this.txtSendEmail.Text;
                ConfirmPassword changePassword = new ConfirmPassword();
                this.Visible = true;
                changePassword.Show();
            }
            else
            {
                MessageBox.Show("Wrong verify code");
            }

        }

       
    }
}


