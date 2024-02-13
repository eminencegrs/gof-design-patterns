namespace DesignPatterns.Builder;

public class EmailDirector
{
    public EmailMessage Construct(Action<IEmailBuilder> builderAction)
    {
        var builder = new EmailBuilder();
        builderAction(builder);
        return builder.Build();
    }
}
