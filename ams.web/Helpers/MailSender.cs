namespace ams.web.Helpers
{
    using System.Net;
    using System.Net.Mail;

    public class MailSender : IMailSender
    {
        private string? host;
        private int port;
        private bool enableSSL;
        private string? username;
        private string? password;

        public MailSender(string? host, int port, bool enableSSL, string? username, string? password)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSSL;
            this.username = username;
            this.password = password;
        }

        public Task MailSendAsync(string mail, string subject, string body)
        {
            var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(username, password),
                EnableSsl = enableSSL,
            };

            return client.SendMailAsync(
                new MailMessage(username ?? "", mail, subject, body) {
                    IsBodyHtml = true
                });
        }
    }
}
