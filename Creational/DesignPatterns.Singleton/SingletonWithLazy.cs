namespace DesignPatterns.Singleton;

public sealed class SingletonWithLazy
{
    private static readonly Lazy<SingletonWithLazy> LazyInstance = new(() => new SingletonWithLazy());

    /// <summary>
    /// The private constructor is declared to prevent instantiation directly, via calling a default constructor. 
    /// </summary>
    private SingletonWithLazy()
    {
        Console.WriteLine($"An instance of {nameof(SingletonWithLazy)} has been created.");
    }

    public static SingletonWithLazy Instance => LazyInstance.Value;
}
