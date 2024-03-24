//using Atbbank.WebUI.Servicess.Abstract;
//using System.Net;
//using System.Net.Mail;

//namespace Atbbank.WebUI.Servicess.Concret
//{
//    public class MailServices : IMailServices
//    {
//        private const string Password = "giksgdsncetpzkbw";
//        private const string OurEmail = "ali.elish@yandex.com";
//        public async Task SendEmailTo(string recipient, string subject, string message)
//        {
//            var client = new SmtpClient("smtp.yandex.com", 587)
//            {
//                EnableSsl = true,
//                Credentials = new NetworkCredential(OurEmail, Password)
//            };
//            var mail = new MailMessage(OurEmail, recipient, subject, message);

//            await client.SendMailAsync(mail);
//        }

//    }
//}
