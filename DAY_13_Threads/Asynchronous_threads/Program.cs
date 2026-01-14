using System;

public class program
{
    public static async Task Asynmethod()
    {
        Console.WriteLine("Task started");
        await Task.Delay(3000);
        Console.WriteLine("Task completed");
    }
    public static async Task<string> FetchDataAsync(string url)
{
    using (HttpClient client = new HttpClient())
    {
        var response = await client.GetStringAsync(url);
        return response;
    }
}

    public  async Task callmethod()
    {
        string data = await FetchDataAsync("https://jsonplaceholder.typicode.com/todos");
        Console.WriteLine(data);
        await Asynmethod();
    }



    public static void Main()
    {
        program p=new program();
        p.callmethod();
        
        
        
    }
}