using System.Net.Mail;
using System.Text;

namespace DesignPatterns.Builder;

public static class MailMessageExtensions
{
    public static string Print(this MailMessage message)
    {
        var sb = new StringBuilder();

        sb.Append($"{nameof(MailMessage.Subject)}: ");
        sb.AppendLine(string.IsNullOrEmpty(message.Subject) ? "No subject" : message.Subject);
        
        sb.Append($"{nameof(MailMessage.From)}: ");
        sb.AppendLine(message.From == null ? "No from" : message.From.ToString());
        
        sb.Append($"{nameof(MailMessage.To)}: ");
        sb.AppendLine(message.To.Count == 0 ? "No to" : message.To[0].ToString());
        
        sb.Append($"{nameof(MailMessage.CC)}: ");
        sb.AppendLine(message.CC.Count == 0 ? "No cc" : message.CC[0].ToString());
        
        sb.Append($"{nameof(MailMessage.Body)}: ");
        sb.AppendLine(string.IsNullOrEmpty(message.Body) ? "No body" : message.Body);

        return sb.ToString();
    }
}