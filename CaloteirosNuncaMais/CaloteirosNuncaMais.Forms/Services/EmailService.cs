using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using CaloteirosNuncaMais.Forms.Enums;
using System.Text;
using System.Net.Mime;
using System;

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

        private static string AddLink(this string html, string url)
        {
            try
            {
                string contentReference = "[[#]]";

                int inicialPosition = html.IndexOf(contentReference);
                int length = contentReference.Length;

                string beforePart = html.Substring(0, inicialPosition);
                string afterPart = html.Substring(inicialPosition + length);

                html = $"{beforePart}{url}{afterPart}".AddLink(url);
            }
            catch { }
            return html;
        }
        public static MailMessage CreateMail(MailAddress email, string content, ETypeEmail emailType, Attachment anexo)
        {
            MailMessage mail = new MailMessage()
            {
                From = new MailAddress(BaseEmail),
                Subject = emailType == ETypeEmail.PROCESSAMENTO
                    ? "Seu empréstimo está em andamento!"
                    : "Seu empréstimo foi concluído!",
                IsBodyHtml = true,
                Body = emailType == ETypeEmail.PROCESSAMENTO 
                    ? Properties.Resources.Processamento.AddLink(content) 
                    : Properties.Resources.Agradecimento, 
                BodyEncoding = Encoding.UTF8,
                HeadersEncoding = Encoding.UTF8,
                BodyTransferEncoding = TransferEncoding.QuotedPrintable
            };
            mail.To.Add(email);
            mail.Attachments.Add(anexo);
            return mail;
        }

        public static async Task<bool> Sending(this MailMessage mail)
        {
            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.SetSmtp();
                try{
                    await smtp.SendMailAsync(mail);
                    return true;
                }
                catch (Exception){
                    return false;
                }
                finally{
                    smtp.Dispose();
                }
            }
        }
    }
}
