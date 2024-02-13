namespace DesignPatterns.Builder;

public class EmailMessage
{
    public EmailMessage()
    {
        this.Attachments = new List<string>();
    }

    public string Sender { get; set; }
    public string Recipient { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public List<string> Attachments { get; set; }

    public void Send()
    {
        Console.WriteLine("Email sent:");
        Console.WriteLine($"From: {this.Sender}");
        Console.WriteLine($"To: {this.Recipient}");
        Console.WriteLine($"Subject: {this.Subject}");
        Console.WriteLine($"Body: {this.Body}");
        Console.WriteLine($"Attachments: {string.Join(", ", this.Attachments)}");
    }
}
