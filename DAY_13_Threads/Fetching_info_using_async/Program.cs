using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;


    //using System;
    //using System.Threading.Tasks;

    //class Program
    //{
    //    static async Task Main()
    //    {
    //        await SaveAsync();                // Task (no return)
    //        int total = await GetTotalAsync(); // Task<int> (returns value)
    //        Console.WriteLine(total);
    //    }

    //    static async Task SaveAsync()
    //    {
    //        await Task.Delay(3000); // pretend we saved to DB
    //        Console.WriteLine("Saved!");
    //    }

    //    static async Task<int> GetTotalAsync()
    //    {
    //        await Task.Delay(300); // pretend we calculated
    //        return 42;
    //    }
    //}



namespace AsyncAwaitExample2
{
    using System.Net.Http;

    public class User
    {
        private async Task FetchJsonAsync()
        {
            try
            {
                string url = "https://jsonplaceholder.typicode.com/todos/1";
                string json = await GetAsync(url);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task FetchGoogleAsync()
        {
            try
            {
                string url = "https://google.com/";
                string json = await GetAsync(url);
                Console.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async Task<string> GetAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }

        public static async Task Main()
        {
            User u = new User();
            await u.FetchJsonAsync();
            await u.FetchGoogleAsync();
        }
    }
}