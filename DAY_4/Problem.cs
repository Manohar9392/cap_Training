using System;
namespace Problem
{
    public class Associate
    {
        private int id;
        private string name;
        private int rank;
        public String log{get;set;}
        public int Id
        {
            set
            {
                if(value<=0)
                {
                    log+="Id must be greater than zero";
                }
                id=value;
                
            }
            get
            {
                return id;
            }
        }
        
        public string Name
        {
            set
            {
                if(Name.Contains("  "))
                {
                    log+="Name cannot be null or empty";
                }
                name=value;
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
                rank=value;
            }
        }



        
    }
}