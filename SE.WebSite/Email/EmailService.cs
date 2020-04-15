using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

namespace SE.WebSite.Email
{
    public class EmailService
    {
        public async Task SendConfirmationEmailAsync(string email, string body, string adminEmail, string adminPassword)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Знатоки безопасности", adminEmail));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = "Подтверждение регистрации";
            emailMessage.Body = new TextPart("Plain")
            {
                Text = body
            };
            using (var client = new SmtpClient())
            {
                client.CheckCertificateRevocation = false;
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync(adminEmail, adminPassword);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendLinkAsync(string email, string materialName, string link, string adminEmail, string adminPassword)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Знатоки безопасности", adminEmail));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = $"Материал {materialName}";
            emailMessage.Body = new TextPart("Plain")
            {
                Text = $"Вы можете скачать материал используя данную ссылку: {link}"
            };
            using (var client = new SmtpClient())
            {
                client.CheckCertificateRevocation = false;
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync(adminEmail, adminPassword);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}
