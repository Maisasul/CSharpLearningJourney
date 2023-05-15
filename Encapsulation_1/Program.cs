using System.Security.Cryptography;

namespace Encapsulation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person class
            Person p1 = new Person();
            p1.SetfName("Maisa");
            p1.SetlName("Sul");
            p1.Setage(1998);
            p1.Setrel("singal");
            p1.Setsalary(200);
            //Console.WriteLine(p1.printInfo());
            p1.printInfo();

            int b = 2023;
            int a = 1998;
            Console.WriteLine(p1.DataB(a,b));

            //BankAccount class
            BankAccount account = new BankAccount();
            //account.SetBalance(2228);
            //decimal amount = 1345;
            //Console.WriteLine("deposite");
            account.deposite(1000);
            account.deposite(300);
            account.withdraw(350);
            account.withdraw(1000);
            //Console.WriteLine("withdraw");
            //Console.WriteLine(account.withdraw(amount));
        }
    }
}