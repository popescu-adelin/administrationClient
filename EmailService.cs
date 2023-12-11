using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Client
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {

                smtpClient.Port = 587; // Common port for SMTP. Use 465 for SSL.
                smtpClient.EnableSsl = true; // Enable SSL if required by your SMTP server
                smtpClient.UseDefaultCredentials = false; // Set to false if you are specifying custom credentials
                smtpClient.Credentials = new System.Net.NetworkCredential("userofhero14@gmail.com", "opydsenpncjzjtji");

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("userofhero14@gmail.com"),
                    Subject = subject,
                    Body = body
                };
                mailMessage.To.Add(to);
                // Send the email
                try
                {
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The message could not be send", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
