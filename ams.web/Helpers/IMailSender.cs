namespace ams.web.Helpers
{
    public interface IMailSender
    {
        Task MailSendAsync(string mail, string subject, string body);
    }
}
