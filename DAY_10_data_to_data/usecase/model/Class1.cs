using System.Transactions;

namespace model{

/// <summary>
/// Interface to implement mandantory Getsummary method...
/// </summary>

public interface IReportable
    {
        public void GetSummary();
    }
    /// <summary>
    /// Created abstract class to define shared values make abstract for not intilizing this class 
    /// </summary>

public abstract class  Transaction
{
    public int Id{get;set;}
    public DateOnly Date{get;set;}

    public decimal Amount{get;set;}

    public string Description{get;set;}
    /// <summary>
    /// constructer to allocate values
    /// </summary>
    /// <param name="id"></param>
    /// <param name="date"></param>
    /// <param name="amount"></param>
    /// <param name="description"></param>

    protected Transaction(int id,DateOnly date,decimal amount,string description)
        {
            Id=id;//assigning id
            Date=date;//assigning date
            Amount=amount;//assigning amount
            Description=description;//assigning description
            
        }




}

public class ExpenseTransaction : Transaction, IReportable
    {
        public string Category{get;set;}
       
        /// <summary>
        ///  ExpenseTransaction Constructer to assign the values of current obj
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <param name="category"></param>

        public ExpenseTransaction(int id,DateOnly date,decimal amount,string description,string category):base(id,date,amount,description)
        {
            Category=category;
            GetSummary();
        }
        /// <summary>
        /// it will summary of transaction...
        /// </summary>

        public void GetSummary()
        {
            Console.WriteLine("Expense details are: ");
            Console.WriteLine($"Id is: {Id}");
            Console.WriteLine($"Date is: {Date}");
            Console.WriteLine($"Spended Amount  is: {Amount}");
            Console.WriteLine($"Category is: {Category}");
            Console.WriteLine($"Description : {Description}");


            
        }
    }
public class IncomeTransaction : Transaction, IReportable
    {
        public string Source{get;set;}

        

        /// <summary>
        /// Constructer to assign the values....
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <param name="source"></param>
        

        public IncomeTransaction(int id,DateOnly date,decimal amount,string description,string source):base(id,date,amount,description)
        {
            Source=source;//assingning source of transaction
            GetSummary();
        }

        /// <summary>
        /// It will give current transaction details..
        /// </summary>

        public void GetSummary()
        {
            Console.WriteLine("Income details are: ");
            Console.WriteLine($"Id is: {Id}");
            Console.WriteLine($"Date is: {Date}");
            Console.WriteLine($"Added Amount  is: {Amount}");
            Console.WriteLine($"Source is: {Source}");
            Console.WriteLine($"Description : {Description}");
            
        }
    }
public class Ledger<T> where T:Transaction
    {
        public List<T> Transactions=new List<T>();//stores the transactions
        /// <summary>
        /// it will add the transctions 
        /// </summary>
        /// <param name="transaction"></param>

        public void AddEntry(T transaction)
        {
            Transactions.Add(transaction);
            
        }

        /// <summary>
        /// This method Filters the transactions based on given date
        /// </summary>
        /// <param name="date"></param>
        /// <returns> list of transaction</returns>

        public List<T> GetTransactionsByDate(DateOnly date)
        {
             List<T> temp=new List<T> ();
            
            foreach(var v in Transactions)
            {
                if (v.Date == date)
                {
                    temp.Add(v);
                }
            }

            return temp;

        }

        /// <summary>
        /// This method calculates all the money by total transactions
        /// </summary>
        /// <returns>totalmoney</returns>

        public  Decimal CalculateTotal()
        {
            decimal total=0;
            foreach(var v in Transactions)
            {
                total+=v.Amount; //adding all the money
            }
            return total;
        }

    }

    public static class Calculation
    {
        public static Ledger<ExpenseTransaction> Expense_details=new Ledger<ExpenseTransaction>();//deals with the ExpenseTransaction
        public static Ledger<IncomeTransaction> Income_details=new Ledger<IncomeTransaction>();//deals with the IncomeTransaction
        /// <summary>
        /// This method will calculate Total Expense 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Total Expense</returns>
        public static decimal CalMethod(Ledger<ExpenseTransaction> obj)
        {
            return obj.CalculateTotal();
            
        }

        /// <summary>
        /// This method will calculate Total Income
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Total Income</returns>
        public static decimal CalMethod(Ledger<IncomeTransaction> obj)
        {
            return obj.CalculateTotal();
            
        }

    }
}
