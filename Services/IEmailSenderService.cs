namespace TestAsp.Services
{
    public interface IEmailSenderService
    {
        public int id { get; }

        void SendEmail(string email);
    }
}
