// using System;
// using DigitalWallet.core;
//  namespace DigitalWalletApp {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             // WalletInfo w=new WalletInfo();
//             // Console.WriteLine(w.Get());

//             WalletData w= new WalletData();
//             w.UserId=101;

//         }
//     }
    
// }

using System;

namespace DigitalWalletApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 5000m;

            object boxedBalance = balance;   // BOXING
            decimal UnboxedBalance=(decimal)boxedBalance;

            Console.WriteLine("Boxed Balance: " + boxedBalance.GetType());
        }
    }
}
