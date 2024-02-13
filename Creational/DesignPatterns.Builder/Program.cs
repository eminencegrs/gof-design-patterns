using DesignPatterns.Builder;

var emailDirector = new EmailDirector();

var email = emailDirector.Construct(builder =>
{
    builder
        .SetSender("sender@example.com")
        .SetRecipient("recipient@example.com")
        .SetSubject("Test Email")
        .SetBody("This is a test email body.")
        .AddAttachment("file.txt")
        .AddAttachment("image.jpg");
});

email.Send();

Console.WriteLine();
