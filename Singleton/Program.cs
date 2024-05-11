public class Singleton
{
    private static Singleton instance;

    private Singleton(){}

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is doing something.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singleton singleton = Singleton.GetInstance();
        singleton.DoSomething();

        Singleton anotherInstance = Singleton.GetInstance();
        Console.WriteLine("Is the same instance: " + (singleton == anotherInstance));

        Console.ReadLine();
    }
}
