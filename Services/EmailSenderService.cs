using TestAsp.Helpers;

namespace TestAsp.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        int IEmailSenderService.id => 1;

        public async void SendEmail(string email)
        {

            DataContext dc = new DataContext();
        }
    }
}
