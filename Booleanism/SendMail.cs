using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booleanism
{
    public partial class SendMail : MetroForm
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var fromAddress = new MailAddress("syedmurtaza108@gmail.com", "Syed Murtaza");
                var toAddress = new MailAddress("syedmurtaza108@gmail.com", roundTextBox1.RoundText);
                const string fromPassword = "1L0TKKFA";
                const string subject = "Response From Booleanism V 2.0";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = richTextBox1.Text + "\n\nID: " + roundTextBox2.RoundText
                })
                {
                    smtp.Send(message);
                }
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism 2.0 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message, "Booleanism 2.0 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Message sending is failed.May be because of incorrect information or network problem", "Booleanism 2.0 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundTextBox2_RoundTextChanged(object sender, EventArgs e)
        {
            if (roundTextBox2.RoundText.Length < 0 || !roundTextBox2.RoundText.Contains('@'))
                exitBtn.Enabled = false;
            else
                exitBtn.Enabled = false;
        }
    }
}
