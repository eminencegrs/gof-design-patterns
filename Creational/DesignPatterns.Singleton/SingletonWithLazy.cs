namespace DesignPatterns.Singleton;

public class SingletonWithLazy
{
    private static readonly Lazy<SingletonWithLazy> instance = new(() => new SingletonWithLazy());

    /// <summary>
    /// The private constructor is declared to prevent instantiation directly, via calling a default constructor. 
    /// </summary>
    private SingletonWithLazy()
    {
        Console.WriteLine($"An instance of {nameof(SingletonWithLazy)} has been created.");
    }

    public static SingletonWithLazy Instance => instance.Value;
}
