
using System;

class Program
{
    static void Main()
    {
        int systems;
        string compatibleData;
        string communication;
        string security;
        double budget;
        string realTime;

        int score = 0;

        Console.WriteLine("HOTEL SYSTEM INTEGRATION READINESS");
        Console.WriteLine("----------------------------------");

      
        Console.Write("Enter number of systems to be integrated: ");
        systems = Convert.ToInt32(Console.ReadLine());

      
        Console.Write("Do the systems use compatible data formats? (yes/no): ");
        compatibleData = Console.ReadLine().ToLower();

     
        Console.Write("Can the systems communicate with each other? (yes/no): ");
        communication = Console.ReadLine().ToLower();

       
        Console.Write("Are proper security measures available? (yes/no): ");
        security = Console.ReadLine().ToLower();

       
        Console.Write("Enter available integration budget: ");
        budget = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Is real-time information needed? (yes/no): ");
        realTime = Console.ReadLine().ToLower();
s

        if (systems >= 3)
        {
            score++;
        }

        if (compatibleData == "yes")
        {
            score++;
        }

        if (communication == "yes")
        {
            score++;
        }

        if (security == "yes")
        {
            score++;
        }

        if (budget >= 10000)
        {
            score++;
        }

        if (realTime == "yes")
        {
            score++;
        }

      
        Console.WriteLine();
        Console.WriteLine("Integration Score: " + score + "/6");

        if (score >= 5)
        {
            Console.WriteLine("RESULT: READY");
        }
        else if (score >= 3)
        {
            Console.WriteLine("RESULT: PARTIALLY READY");
        }
        else
        {
            Console.WriteLine("RESULT: NOT READY");
        }
    }
}
```