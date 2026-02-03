using System;

class Controller
{
    static void Main()
    {
        // TODO:
        try
        {
            Service.Process();
        }
        catch(ApplicationException Ex)
        {
            Console.WriteLine($"Controller caught an exception: {Ex.Message}");
        }
        finally
        {
                       Console.WriteLine("Controller cleanup actions");
        }
        // Call Service method
        // Handle exception here
    }
}

class Service
{
    public static void Process()
    {
        try
        {
            Repository.GetData();
        }
        catch(InvalidDataException Ex)
        {
            Console.WriteLine($"Service caught an exception: {Ex.Message}");

            throw new ApplicationException("Service layer error ");
        }
        finally
        {
                       Console.WriteLine("Service cleanup actions");
        }
        // TODO:
        // Call Repository method
        // Catch, log and rethrow exception
    }
}

class Repository
{
    public static void GetData()
    {
        // TODO:
        // Throw an exception here
        throw new InvalidDataException("Data retrieval error");
    }
}