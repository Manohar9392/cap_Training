using System;
namespace inherit
{
    public class Father
    {
        public  virtual String InterestedOn()
        {
            return " I like Football";
        }
    }
    public class Son:Father
    {
        public override  String InterestedOn()
        {
            return " I like Cricket";
        }
    }
}