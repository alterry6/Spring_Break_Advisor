using System;

class SpringBreakAdvisor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Spring Break Advisor!");
        Console.WriteLine("-------------------------------");
        
        string userVibe;
        do
        {
            // Get user's vacation preference
            userVibe = GetSpringBreakVibe();
            
            // Only process if user hasn't chosen to exit
            if (userVibe.ToLower() != "exit")
            {
                var destination = GetDestinationRecommendation(userVibe);
                var activity = GetActivityRecommendation(destination);
                
                // Show results to user
                Console.WriteLine(DisplaySpringBreakDetails(userVibe, activity, destination));
                Console.WriteLine("\nWant to try another? (type 'exit' to quit)");
                Console.WriteLine();
            }
        } while (userVibe.ToLower() != "exit");

        Console.WriteLine("Thanks for using Spring Break Advisor! Have a great vacation!");
    }

    static string GetSpringBreakVibe()
    {
        // Show menu options
        Console.WriteLine("\nHow do you want your spring break to feel?");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1. Relaxing (perfect for unwinding)");
        Console.WriteLine("2. Adventurous (for thrill seekers)");
        Console.WriteLine("3. Party (time to socialize!)");
        Console.WriteLine("4. Luxurious (treat yourself)");
        Console.Write("\nEnter your choice (1-4 or type 'exit'): ");
        
        return Console.ReadLine();
    }

    static string GetDestinationRecommendation(string vibe)
    {
        // Convert numeric or text input to destination
        switch (vibe.ToLower())
        {
            case "relaxing":
            case "1":
                return "Maldives Beach Resort";
            
            case "adventurous":
            case "2":
                return "Rocky Mountain National Park";
            
            case "party":
            case "3":
                return "Miami, FL";
            
            case "luxurious":
            case "4":
                return "Monte Carlo, Monaco";
            
            default:
                return "Invalid choice - please try again";
        }
    }

    static string GetActivityRecommendation(string destination)
    {
        // Match activity to destination
        switch (destination)
        {
            case "Maldives Beach Resort":
                return "Sunset Yoga on the Beach";
            
            case "Rocky Mountain National Park":
                return "Hiking to Emerald Lake";
            
            case "Miami, FL":
                return "Nightlife at South Beach";
            
            case "Monte Carlo, Monaco":
                return "Yacht Cruise along the Riviera";
            
            default:
                return "Please select a valid destination first";
        }
    }

    static string DisplaySpringBreakDetails(string vibe, string activity, string destination)
    {
        return $"\n------------------------------------------------------------------------" +
               $"\n------------------------------------------------------------------------" +
               $"\n Your Perfect Spring Break " +
               $"\n--------------------------------" +
               $"\nVibe: {vibe}" +
               $"\nDestination: {destination}" +
               $"\nMust-try Activity: {activity}" + 
               $"\n-------------------------------------------------------------------------" +
               $"\n-------------------------------------------------------------------------";
    }
} 