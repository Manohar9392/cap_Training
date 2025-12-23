using System;
namespace Problem
{
    public class Associate
    {
        private int id;
        private string name;
        private int rank;
        public String? log{get;set;}
        public int Id
        {
            set
            {
                if(value<=0)
                {
                    log+="Id must be greater than zero";
                }
                else{
                id=value;
                }
            }
            
        }
        
        public string Name
        {
            set
            {
                if(value.Contains("  "))
                {
                    log+="Name cannot be null or empty";
                }
                else{
                name=value;
                }
            }
            
        }
        
        public int Rank
        {
            set
            {
                if(value<0)
                {
                    log+="Rank cannot be negative";
                }
                else{
                rank=value;
                }
            }
            
        }

        public Associate()
        {
            log="";
        }   
        public Associate(int id):this()
        {
            Id=id;
        }
        public Associate(int id,string name):this(id)
        {
            Name=name;
        }
        public Associate(int id,string name,int rank):this(id,name)
        {
            Rank=rank;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {id}\nName: {name}\nRank: {rank}\nLog: {log}");
        }



        
    }
    
}