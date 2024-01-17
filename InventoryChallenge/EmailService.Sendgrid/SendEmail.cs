using InventoryChallenge.EmailProvider.Contract;

namespace EmailService.Sendgrid
{
    public class Email : ISendEmail
    {
        public async Task ISendEmail.SendEmail(string htmlBody, string textBody, string to, string from)
        {
            throw new NotImplementedException();
        }
    }
}