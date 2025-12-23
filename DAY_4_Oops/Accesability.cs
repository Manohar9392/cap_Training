using System;
namespace Accesability
{
    public class Account
    {
        public int Id{get;set;}
        public string? Name{get;set;}

        public String GetDetails()
        {
            return $"this is from base class . Id is {Id}";
        }
    }
    public class SalesAccount : Account
    {
        public required string SalesInfo{get;set;}

        public String GetSalesDetails()
        {
            String info="";
             info+= base.GetDetails();
            info += $"this is from Sales derived class";
            return info;
        }
    }
    public class Purchase_account : Account
    {
        public string? PurchaseInfo{get;set;}

        public String GetPurchaseDetails()
        {
            String info="";
             info+= base.GetDetails();
            info += $"this is from Purchase derived class";
            return info;
        }
    }
}