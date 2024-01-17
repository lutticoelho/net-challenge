namespace InventoryChallenge.EmailProvider.Contract
{
    public interface ISendEmail
    {
        public Task SendEmail(string htmlBody, string textBody, string to, string from); //Could be an object instead.
    }
}