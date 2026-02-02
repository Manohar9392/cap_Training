namespace model{

public interface IMovie
    {
        
    }

public class Movie:IMovie
{
    public string Title{get;set;}
    public string Director{get;set;}

    public int Year{get;set;}


}


public interface IFilmLibrary
    {
        public void AddFilm(Movie m);
        
    }
public class FilmLibrary : IFilmLibrary
    {
        private List<IMovie> _films=new List<IMovie>();

        public void AddFilm(IMovie m)
        {
            _films.Add(m);
            
        }
        public void RemoveFim(string title)
        {
            _films.Count();
        }
        
    }
}
