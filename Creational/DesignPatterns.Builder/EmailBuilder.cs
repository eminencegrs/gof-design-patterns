namespace DesignPatterns.Builder;

public class EmailBuilder : IEmailBuilder
{
    private readonly EmailMessage emailMessage = new();

    public IEmailBuilder SetSender(string sender)
    {
        this.emailMessage.Sender = sender;
        return this;
    }

    public IEmailBuilder SetRecipient(string recipient)
    {
        this.emailMessage.Recipient = recipient;
        return this;
    }

    public IEmailBuilder SetSubject(string subject)
    {
        this.emailMessage.Subject = subject;
        return this;
    }

    public IEmailBuilder SetBody(string body)
    {
        this.emailMessage.Body = body;
        return this;
    }

    public IEmailBuilder AddAttachment(string attachment)
    {
        this.emailMessage.Attachments.Add(attachment);
        return this;
    }

    public EmailMessage Build()
    {
        return this.emailMessage;
    }
}
