namespace DesignPatterns.Singleton;

public class SingletonWithLock
{
    private static SingletonWithLock? instance = null;
    private static readonly object lockObj = new();

    /// <summary>
    /// The private constructor is declared to prevent instantiation directly, via calling a default constructor. 
    /// </summary>
    private SingletonWithLock()
    {
        Console.WriteLine($"An instance of {nameof(SingletonWithLock)} has been created.");
    }

    public static SingletonWithLock Instance
    {
        get
        {
            // The cost of executing the lock operation is significantly higher
            // in comparison to the straightforward pointer check `instance != null`.
            lock (lockObj)
            {
                return instance ??= new SingletonWithLock();
            }
        }
    }
}
