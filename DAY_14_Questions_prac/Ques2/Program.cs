using System;
using model;

public class Program
{
    public void AddMovie(string details)
    {
        string[] list=details.Split(",");
        int ratings=int.Parse(list[3]);
        MovieList.Add(new Movie{Title=list[0],Artist=list[1],Genre=list[2],Ratings=ratings});
    }
    public List<Movie> ViewMoviesBygenre(string genre)
    {
        List<Movie> temp=new List<Movie>();
        foreach(var v in MovieList)
        {
            if(v.Genre==genre)
            {
                temp.Add(v);
            }
        }
        return temp;
    }

    public List<Movie> ViewMoviesByRatings()
    {
        return MovieList.OrderBy(p=>p.Ratings).ToList();
    }
    public static List<Movie> MovieList=new List<Movie>();
    public static void Main()
    {
        Program p=new Program();
        string details="";
        while(true)
        {
            Console.Write("Enter the Details Of Movie or exit to close:");
            details=Console.ReadLine();
            if(details=="exit")
            {
                break;
            }
            p.AddMovie(details);

        }


        Console.Write("Enter the genre to search: ");
        string genre=Console.ReadLine();
        List<Movie> res=p.ViewMoviesBygenre(genre);
        foreach(var v in res)
        {
            Console.WriteLine($"movie name is : {v.Title}");
        }

        List<Movie> res1=p.ViewMoviesByRatings();
        Console.WriteLine("Movies sort by rating are: ");
        foreach(var v in res1)
        {
            Console.WriteLine($"Movie {v.Title} with rating is {v.Ratings}");
        }
        
    }
}