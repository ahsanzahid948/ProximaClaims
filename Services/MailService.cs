using Microsoft.Extensions.Options;
using MimeKit;
using ProximaClaims.HelperModels;
using ProximaClaims.Models;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Mime;

namespace ProximaClaims.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task SendEmailAsync(Contact mailRequest)
        {
            try
            {
                MailSettings mailSettings = new MailSettings() { Host = "proximaclaims.com", Mail = "info@proximaclaims.com", Port = 25, Password = "!Proximaclaims" };



                var smtpClient = new SmtpClient(mailSettings.Host, mailSettings.Port);
                smtpClient.Credentials = new System.Net.NetworkCredential(mailSettings.Mail, mailSettings.Password);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();

                //Setting From , To and CC
                mail.From = new MailAddress("info@proximaclaims.com", "customer inquiry");
                mail.To.Add(new MailAddress("info@proximaclaims.com"));
                mail.CC.Add(new MailAddress("support@proximaclaims.com"));
                mail.Body = "Customer Email:"+ mailRequest.Email+"\n Customer Practice:" + mailRequest.Practice+"\n Customer Number:"+ mailRequest.Phone+"\n\n"+ mailRequest.Message;

                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
