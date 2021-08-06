using LKGGroup.Bookstore.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Service
{
    public class EmailService //: IEmailService
    {
        private const string tamplatePath = @"EmailTamplate/{0}.html";
        private readonly SMTPConfigModel _smtpConfig;

        //public async Task SendTestEmail(UserEmailOptions userEmailOptions)
        //{
        //    userEmailOptions.Subject = "This is test subject form LKG book store web app";
        //    userEmailOptions.Body = GetEmailBody("TestEmail");

        //    await SendEmail(userEmailOptions);
        //}

        public EmailService(IOptions<SMTPConfigModel> smtpConfig)
        {
            _smtpConfig = smtpConfig.Value;
        }
        private async Task SendEmail(UserEmailOptions userEmailOptions)
        {
            MailMessage mail = new MailMessage
            {
                Subject = userEmailOptions.Subject,
                Body = userEmailOptions.Body,
                From = new MailAddress(_smtpConfig.SenderAddress, _smtpConfig.SenderDisplayName),
                IsBodyHtml = _smtpConfig.IsBoadyHTML
            };

            foreach (var toEmail in userEmailOptions.ToEmails)
            {
                mail.To.Add(toEmail);
            }

            NetworkCredential networkCredential = new NetworkCredential(_smtpConfig.UserName, _smtpConfig.Password);

            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpConfig.Host,
                Port = _smtpConfig.Port,
                EnableSsl = _smtpConfig.EnableSSL,
                UseDefaultCredentials = _smtpConfig.UseDefaultCredentials,
                Credentials = networkCredential
            };

            mail.BodyEncoding = Encoding.Default;

            await smtpClient.SendMailAsync(mail);
        }

        private string GetEmailBody(string tamplateName)
        {
            var body = File.ReadAllText(string.Format(tamplatePath, tamplateName));
            return body;
        }
    }
}
