//Yareni Perez
//IT112
// Notes: 
namespace Perez_MultiUserBank_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank Trans = new Bank();
            Console.WriteLine("The Banks cash on hand is: " + Trans.BankBalance.ToString("C"));
            Console.WriteLine("Log in Below.");
            Console.Write("username:");
            string username = Console.ReadLine();
            Console.Write("password:");
            string password = Console.ReadLine();

            do
            {

                if (Trans.CheckId(username, password) == true)
                {
                    Console.WriteLine("Hey " + username + " choose an option below!");

                    Console.WriteLine(": 1 - Deposit 2 - Withdraw 3 - Check Balance 4 - Log off");
                    decimal decision = int.Parse(Console.ReadLine());
                    if (decision == 1)
                    {
                        Console.Write("Enter the amount you want to deposit:");
                        decimal depositamount = Convert.ToDecimal(Console.ReadLine());
                        Trans.BankBalancedeposit(depositamount);
                        Console.WriteLine(Trans.Deposit(depositamount, username).ToString("C"));

                    }
                    if (decision == 2)
                    {
                        Console.Write("Enter the amount you want to withdraw:");
                        decimal withdrawamount = Convert.ToDecimal(Console.ReadLine());
                        Trans.withdrawbank(withdrawamount, username);
                        Console.WriteLine(Trans.withdraw(withdrawamount, username).ToString("C"));

                    }

                    if (decision == 3)
                    {
                        if (username == "jlennon")
                        {
                            Console.WriteLine(Trans.User1Balance.ToString("C"));
                        }
                        if (username == "pmccartney")
                        {
                            Console.WriteLine(Trans.User2Balance.ToString("C"));
                        }

                        if (username == "gharrison")
                        {
                            Console.WriteLine(Trans.User3Balance.ToString("C"));
                        }

                        if (username == "rstarr")
                        {
                            Console.WriteLine(Trans.User4Balance.ToString("C"));
                        }

                    }

                    if (decision == 4)
                    {
                        Console.Clear();

                        Console.WriteLine("The Banks cash on hand is: " + Trans.BankBalance.ToString("C"));


                        Console.Write("username:");
                        username = Console.ReadLine();
                        Console.Write("password:");
                        password = Console.ReadLine();


                        Console.Clear();
                    }


                }

                if (Trans.CheckId(username, password) == false)
                {
                    Console.WriteLine("User Not Found.");
                    Console.Write("username:");
                    username = Console.ReadLine();
                    Console.Write("password:");
                    password = Console.ReadLine();
                }

            } while (true);

        }
    }
}