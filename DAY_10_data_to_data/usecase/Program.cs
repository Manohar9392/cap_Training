using System;
using model;

public class Program
{
    /// <summary>
    /// Starting of program Digital Petty Cash Ledger System which builds in such a way it will ease the transactions of a person..
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        

        bool flag=true;//control the Transaction loop until exit
        int choice;//stores the customer choice

        Console.WriteLine("------------------------Welcome to Digital Petty Cash Ledger System!-------------------------");


        while(flag)
        {
            ///
            /// Menu bar of transaction System
            Console.WriteLine("choose one option from below");
            Console.WriteLine("Enter 1 for Income_Transaction! ");
            Console.WriteLine("Enter 2 for Expense_Transaction! ");
            Console.WriteLine("Enter 3 for Total_Income! ");
            Console.WriteLine("Enter 4 for Total_Expense_Transaction! ");
            Console.WriteLine("Enter 5 for filter Income_Transaction by date! ");
            Console.WriteLine("Enter 6 for filter Expense_Transaction by date! ");
            Console.WriteLine("Enter 0 for Exit! ");

            Console.Write("Enter choice: ");
            choice=int.TryParse(Console.ReadLine(),out choice)?choice:0;
            Console.WriteLine("-----------------------------------------------------------------------------------");

            switch(choice)
            {
                case 1:
                        Console.WriteLine("Enter Income details-");
                        Console.Write("Enter Id: ");
                        int id=int.TryParse(Console.ReadLine(),out id)?id:0;
                        Console.Write("Enter date: ");
                        DateOnly date = DateOnly.Parse(Console.ReadLine());
                        Console.Write("Enter Amount: ");
                        decimal amount=decimal.TryParse(Console.ReadLine(),out amount)?amount:0;
                        Console.Write("Enter Description: ");
                        string description=Console.ReadLine();
                        Console.Write("Enter Source: ");
                        string source=Console.ReadLine();


                        IncomeTransaction ex=new IncomeTransaction(id,date,amount,description,source);
                        Calculation.Income_details.AddEntry(ex);//stores the Income Transaction for future refrence
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                                break;

                case 2:
                        Console.WriteLine("Enter Expense details-");
                        Console.Write("Enter Id: ");
                        int id1=int.TryParse(Console.ReadLine(),out id)?id:0;
                        Console.Write("Enter date: ");

                        DateOnly date1 = DateOnly.Parse(Console.ReadLine());
                        Console.Write("Enter Amount: ");
                        decimal amount1=decimal.TryParse(Console.ReadLine(),out amount)?amount:0;
                        Console.Write("Enter Description: ");
                        string description1=Console.ReadLine();
                        Console.Write("Enter Category: ");
                        string category1=Console.ReadLine();


                        ExpenseTransaction ex1=new ExpenseTransaction(id1,date1,amount1,description1,category1);
                        Calculation.Expense_details.AddEntry(ex1);//stores the Expense Transaction for future refrence
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;

                case 3:
                        Console.WriteLine($"Total income is: {Calculation.CalMethod(Calculation.Income_details)}");
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;

                case 4:
                        Console.WriteLine($"Total Expenses is: {Calculation.CalMethod(Calculation.Expense_details)}");
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;

                case 5:
                        Console.Write("Enter date:");
                        DateOnly temp_date=DateOnly.Parse(Console.ReadLine());
                        var list=Calculation.Income_details.GetTransactionsByDate(temp_date);
                        if(list.Count==0)
                                        {
                                                Console.WriteLine($"No income details on {temp_date}enter first Income Details!");
                                        }
                        else{
                                foreach(var v in list)
                                    {
                                        v.GetSummary();
                                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                    }
                        }
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;

                case 6:
                        Console.Write("Enter date:");
                        DateOnly temp_date1=DateOnly.Parse(Console.ReadLine());
                        var list1=Calculation.Expense_details.GetTransactionsByDate(temp_date1);
                        if(list1.Count==0)
                                        {
                                                Console.WriteLine($"No Expense Happened on {temp_date1}!");
                                        }
                        else{
                                foreach(var v in list1)
                                    {
                                        v.GetSummary();
                                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                    }
                        }
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;


                case 0:
                        Console.WriteLine("System closed successfully Thank you for using our service");
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        flag=false;
                        break;

                default:
                        Console.WriteLine("Enter the choice from menu!");
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        break;


            }

        }


      


    }
}