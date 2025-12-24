namespace Inheritance{

public class Person
    {
        public string Name{ get; set; }
        public int Age{ get; set; }

    }
public class Man: Person
    {
        public void Display()
        {
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Age: " + Age);
        }
    }   
}
