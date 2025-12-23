using System;

namespace Constructers{

public class Visitor
{
    public int Id{get; set;}
    public string Name;
    public string Requirement;

    private Visitor()
    {
        
    }

    public Visitor(int id,string name,string requirement)
    {
        this.Id=id;
        this.Name=name;
        this.Requirement=requirement;
    }

    public Visitor(int id,string name)
    {
        if(id<0)
            {
                throw new ArgumentException("Id should not be negative");
            }
        this.Id=id;
        if(name.ToLower().Contains("idiot"))
            {
                throw new ArgumentException("Name should be free from abusive words");
            }
        this.Name=name;
    }
    public Visitor(int id)
    {
        this.Id=id;
    }

    public void Display()
    {
        Console.WriteLine("Id: "+Id);
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Requirement: "+Requirement); 
    }
}

}