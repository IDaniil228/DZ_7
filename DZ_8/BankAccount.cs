using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8
{
    public enum Account { Текущий, Сберегательный }
    public class BankAccount
    {
        private static int numbOfAccount;
        private double balance;
        private Account accountType;

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public void Set(double balance, int type)
        {
            numbOfAccount++;
            this.balance = balance;
            accountType = (Account)type;
        }
        public double AddBalince(double balance)
        {
            this.balance += balance;
            return balance;
        }
        public double WithdrawFromBalance(double balance)
        {
            this.balance -= balance;
            return balance;
        }
        public int GetNumber()
        {
            return numbOfAccount;
        }
        public string GetAccountType()
        {
            return accountType.ToString();
        }
        public void Transfer(BankAccount account, double amount)
        {
            if (account != null && account.Balance > 0 && amount <= account.Balance)
            {
                account.balance -= amount;
            }
            else 
            {
                Console.WriteLine("Невозможно снять деньги с этого счета");
            }
        }
    }
}
