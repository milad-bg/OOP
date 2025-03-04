namespace OOP.Encapsulation;

// Apply encapsulation using Access Modifiers
public class Benz : ICar
{
    // Will be called only once in constructor, later you cant change it from outside of this class.
    public string Name { get; private set; }


    public Benz(string modelName)
    {
        Name = modelName;
    }

    // Public method that users of this class should see and use. 
    public bool Start()
    {
        var safeState = PerformSafetyChecks();
        var componentsInitialized = InitializeComponents();
        var engineIgnited = IgniteEngine();

        var carStarted = safeState && componentsInitialized && engineIgnited;
        if (carStarted)
        {
            Console.WriteLine("Electric motor started.");

            return true;
        }

        Console.WriteLine("Failed to start the engine");
        return false;
    }

    // Private methods which are internal behavior of this class and should not be exposed out because users of this class better not know about details of this class implementation.
    private bool IgniteEngine()
    {
        // Simulate checks
        return true;
    }

    private bool InitializeComponents()
    {
        // Simulate checks
        return true;
    }

    private bool PerformSafetyChecks()
    {
        // Simulate checks
        return true;
    }
}