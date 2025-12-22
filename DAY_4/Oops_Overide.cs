using System;
namespace inherit
{
    public sealed class GrandFather
    {
        public String Heritage()
        {
            return "I have a Heritage";
        }
    }
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