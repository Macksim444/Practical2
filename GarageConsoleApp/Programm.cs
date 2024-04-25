namespace GarageConsoleApp;

public class Program 
{
    public static void Main(string[] args)
    {
        DatabaseRequests.GetDriverQuery();
        Console.WriteLine();
        
        DatabaseRequests.AddDriverQuery("Максим", "Бичевин", DateTime.Parse("2006.02.06"));
        DatabaseRequests.GetDriverQuery();
        
        DatabaseRequests.GetTypeCarQuery();
        Console.WriteLine();
        
        DatabaseRequests.AddTypeCarQuery("Наземный");
        DatabaseRequests.GetTypeCarQuery();
        
        DatabaseRequests.AddCarQuery(1,"Dodge Challenger","C7771BD",25);
        DatabaseRequests.GetCarQuery();
        
        DatabaseRequests.AddRouteQuery(1,1,1, 20);
        DatabaseRequests.GetRouteQuery();
        
        DatabaseRequests.AddItineraryQuery("Томск-Америка");
        DatabaseRequests.GetItineraryQuery();
    }
}

