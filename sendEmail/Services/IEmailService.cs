using sendEmail.Models;

namespace sendEmail.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
