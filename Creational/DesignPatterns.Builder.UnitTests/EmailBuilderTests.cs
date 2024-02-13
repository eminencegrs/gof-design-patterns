using FluentAssertions.Execution;
using Shouldly;
using Xunit;

namespace DesignPatterns.Builder.UnitTests;

public class EmailBuilderTests
{
    [Fact]
    public void Given_WhenConstructEmail_ThenResultAsExpected()
    {
        const string sender = "sender@example.com";
        const string recipient = "recipient@example.com";
        const string subject = "Test Email";
        const string body = "This is a test email body.";
        var attachments = new [] { "file.txt", "image.jpg" };

        var emailDirector = new EmailDirector();

        var email = emailDirector.Construct(builder =>
        {
            builder
                .SetSender(sender)
                .SetRecipient(recipient)
                .SetSubject(subject)
                .SetBody(body);
                
            foreach(var attachment in attachments)
            {
                builder.AddAttachment(attachment);
            }
        });

        using (new AssertionScope())
        {
            email.Sender.ShouldBe(sender);
            email.Recipient.ShouldBe(recipient);
            email.Subject.ShouldBe(subject);
            email.Body.ShouldBe(body);
            email.Attachments.ShouldBe(attachments);
        }
    }
}
