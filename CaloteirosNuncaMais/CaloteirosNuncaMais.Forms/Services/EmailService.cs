using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace CaloteirosNuncaMais.Forms.Services
{
    public static class EmailService
    {
        private static readonly string BaseEmail = Properties.Settings.Default.Email;
        private static readonly string BasePassword = Properties.Settings.Default.Password;

        private static SmtpClient SetSmtp(this SmtpClient smtp)
        {
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(BaseEmail, BasePassword);

            return smtp;
        }

        public static MailMessage CreateMail(string email)
        {
            MailMessage mail = new MailMessage()
            {
                From = new MailAddress(BaseEmail),
                Subject = "Uma nova senha foi gerada para o sistema MargiLandsAndLeads",
                Body = "",
            };
            mail.To.Add(email);
            return mail;
        }

        public static async Task<bool> Sending(this MailMessage email)
        {
            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.SetSmtp();
                await smtp.SendMailAsync(email);
            }
        }
    }
}
