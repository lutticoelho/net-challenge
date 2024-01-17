using InventoryChallenge.EmailProvider.Contract;

namespace EmailService.Twillio
{
    public class SendEmail : ISendEmail
    {
        public async Task ISendEmail.SendEmail(string htmlBody, string textBody, string to, string from)
        {
            throw new NotImplementedException();
        }
    }
}