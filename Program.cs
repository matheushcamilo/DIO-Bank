using System;
namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account conta = new Account("Matheus", AccountType.FiscalPerson, 1000, 500);
            System.Console.WriteLine(conta.NewBalance(3000));
        }
    }
}
