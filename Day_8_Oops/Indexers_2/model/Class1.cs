using System.Diagnostics;

namespace model{

public class Mydata
{
    public string? Name{get;set;}
    public int Id{get;set;}

    private string? address{get;set;}
    /// <summary>
    /// Property to deal with address Field...
    /// </summary>
    public string Address
        {
            get
            {
                if(address==null)
                {
                    return "first assign address";
                }
                else
                {
                return address;
                }
            }
            set
            {
                address=value;
            }
        }
    private List<string>? Books=new List<string>();  //Creating private list to store Books names...
    /// <summary>
    /// Indexer of obj to access books like array;
    /// </summary>
    /// <param name="index"></param>
    /// <returns>Book Name</returns>
    public string this[int index]
        {
            ///getter
            get
            {
                if(index>=0 && index<Books.Count)
                {
                return Books[index];
                }
                else
                {
                    return "Index out of Bound";
                }
            }
            //setter
            set
            {
                if(index==Books.Count)
                {
                Books.Add(value);
                }
                else if(index<Books.Count)
                {
                    Books[index]=value;
                }
                else
                {
                    Console.WriteLine ("Invalid Index");
                }
            }
        }

}
}
