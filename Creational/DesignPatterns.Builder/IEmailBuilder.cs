namespace DesignPatterns.Builder;

public interface IEmailBuilder
{
    IEmailBuilder SetSender(string sender);
    IEmailBuilder SetRecipient(string recipient);
    IEmailBuilder SetSubject(string subject);
    IEmailBuilder SetBody(string body);
    IEmailBuilder AddAttachment(string attachment);
    EmailMessage Build();
}
