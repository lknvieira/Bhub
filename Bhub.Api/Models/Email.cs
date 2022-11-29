namespace Bhub.Api.Models
{
    public class Email
    {
        public Email(string to, string from, string subject)
        {
            To = to;
            From = from;
            Subject = subject;
        }

        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
    }
}
