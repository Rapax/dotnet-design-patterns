using System.Net.Mail;
using System.Text;

namespace DesignPatterns.Builder;

public class MailMessageBuilder
{
    private readonly MailMessage _mailMessage = new MailMessage();
    public MailMessageBuilder From(string address)
    {
        _mailMessage.From = new MailAddress(address);
        return this;
    }
    public MailMessageBuilder To(string address)
    {
        _mailMessage.To.Add(address);
        return this;
    }
    public MailMessageBuilder Cc(string address)
    {
        _mailMessage.CC.Add(address);
        return this;
    }
    public MailMessageBuilder Subject(string subject)
    {
        _mailMessage.Subject = subject;
        return this;
    }
    
    public MailMessageBuilder Body(string body, Encoding encoding)
    {
        _mailMessage.Body = body;
        _mailMessage.BodyEncoding = encoding;
        return this;
    }
    public MailMessage Build()
    {
        return _mailMessage;
    }
}