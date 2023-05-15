using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation_1
{
    class BankAccount
    {
        private const decimal MAXDEPOSIT = 1000;
        private int AccountNumber;
        private decimal Balance;

        public int GetAccountNumber()
        {
            return AccountNumber;
        }
        public void SetAccountNumber(int AccountNumber) 
        {
            this.AccountNumber = AccountNumber;
        }
        public decimal GetBalance() 
        {
            return Balance;
        }
        public void SetBalance(decimal Balance) 
        {
            this.Balance = Balance;
        }
        
        public void deposite(decimal amount) 
        {
            if (amount <= 0) 
            {
                log($"invalid you can't add {amount} to your bank account");
                return;
            }
            Balance += amount;
            log($"successfull operation you add {amount} to your bank account");
        }

        public void withdraw(decimal amount) 
        {
            if (amount <= 0)
            {
                log($"invalid Operation you can't with Draw with negative amount");
                return;
            }
            if(amount > MAXDEPOSIT) 
            {
                log($"invalid Operation you can't exceed your Maximum withDraw amount");
                return;
            }
            if(amount > Balance) 
            {
                log($"invalid operation you can't withdraw {amount} from your account");
                return;
            }
            Balance -= amount;
            log($"successful opertion you have withdraw {amount} from your account");
        }

        public void log(string message)
        {
            string Timestamp = DateTime.Now.ToString(" yyyy-mm-dd  hh-mm ");
            Console.WriteLine($" [{Timestamp}] {message} ");
        }
    }
}
