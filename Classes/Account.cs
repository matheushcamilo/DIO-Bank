 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Bank
{
    public class Account
    {
        public Account(string clientName, AccountType type, double balance, double revolvingCredit)
        {
            ClientName = clientName;
            Type = type;
            Balance = balance;
            RevolvingCredit = revolvingCredit;
        }

        static double InterestRate {get; set;}

        string ClientName{get; set;}
        AccountType Type{get; set;}
        double Balance{get; set;}
        double RevolvingCredit{get; set;}

        //New balance defined by signal of bank operation and current balance value
        public double NewBalance(double bankOperation){ return Balance + bankOperation >= -RevolvingCredit ?
         Balance + bankOperation : throw new Exception("Withdrawal value beyond acceptable amount!!!");}
        
        
        
        
    }
}