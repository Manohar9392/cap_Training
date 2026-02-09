using System;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        #region this is sequential execution takes 6 seconds to completed
        await SaveAsync();                // Task (no return)
        int total = await GetTotalAsync(); // Task<int> (returns value) 
                                           // these two tasks run one after another
                                           // await will take care not blocking the main thread
                                           // but thread.sleep will block the main thread
        Console.WriteLine(total);
        #endregion


        #region this is parallel exucution takes 3 seconds to completed

        Task saveTask = SaveAsync();
        Task<int> totalTask = GetTotalAsync();
        await Task.WhenAll(saveTask, totalTask);

        Console.WriteLine(totalTask.Result);

        #endregion


    }

    static async Task SaveAsync()
    {
        await Task.Delay(3000); // pretend we saved to DB
        Console.WriteLine("Saved!");
    }

    static async Task<int> GetTotalAsync()
    {
        await Task.Delay(3000); // pretend we calculated
        return 42;
    }
}