using System.Net.Mail;
using System.Text;

namespace NetSimpleScheduler
{
    public class SendEmail
    {
        public void Send(string subject, string body, string emailTo)
        {
            //setup email here
            string fromEmail = "admin@example.com";
            string fromPassword = "password";
            string host = "mail.example.com";
            int port = 587;

            SmtpClient client = new SmtpClient();
            client.Port = port;
            client.Host = host;
            client.EnableSsl = true;
            client.Timeout = 60000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(fromEmail, fromPassword);

            MailMessage mm = new MailMessage(fromEmail, emailTo, subject, body);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }
    }
}