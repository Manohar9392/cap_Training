namespace model{

public class Person
{
    public string Name{get;set;}
    public int Age{set;get;}
     public string Address{get;set;}

     public Person(string name,int age,string address)
        {
            Name=name;
            Age=age;
            Address=address;
        }

}

public class PersonImplementation
    {
        /// <summary>
        /// Method which list all the name with addresses
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>All the names with address</returns>
        public string GetName(IList<Person> persons)
        {
            string result="";
            foreach(var v in persons)
            {
                result+= $"{v.Name} {v.Address} ";
            }
            return result;
        }

        /// <summary>
        /// This method Will calculate Average Age of all the persons
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Average age</returns>

        public decimal Average(IList<Person> persons)
        {
            decimal sum=0;
            foreach(var v in persons)
            {
                sum+=v.Age;
            }
            decimal res=sum/persons.Count;
            return res;
        }

        /// <summary>
        /// This Method will give Max age
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>int </returns>

        public int Max(IList<Person> persons)
        {
            int large=0;
            foreach(var v in persons)
            {
                if(v.Age>large)
                {
                    large=v.Age;
                }
            }

            return large;
        }
    }

    public static class Data
    {
        public static IList<Person> Persons=new List<Person>();

        static Data(){
            
        }
    }


}
