using sisfolha.Entidades;
using System;
using System.Globalization;

namespace sisfolha.Testes {
    class TesteBusinessAccount {
        public static void cadastroConta() {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brow", 100.0, 500.0);
            Console.WriteLine(account.Balance);
        }
        public static void cadastrarPoupanca() {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bcc = new BusinessAccount(1002, "Maria", 0.00, 500.00);

            //UpCasting
            Account acc1 = bcc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.00, 500.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.00, 0.01);

            //DownCasting

            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.0);

           // BusinessAccount acc5 = (BusinessAccount) acc3;
            if (acc3 is BusinessAccount) {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                // Operado as serve com casting também
                acc5.Loan(200.00);
                Console.WriteLine("Loan! ");
            }
            if (acc3 is SavingsAccount) {
                //SavingsAccount acc5 = (SavingsAccount)acc3;  // Entre parenteses casting também
                SavingsAccount acc5 = acc3 as SavingsAccount;  // as casting
                acc5.UppdateBalance();
                Console.WriteLine("Uppdate!");
            }

        }
        public static void saqueConta() {
            Account acc1 = new Account(1002, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1001, "Anna", 500.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.00);

            Console.WriteLine("Saldo 1 ->> " + acc1.Balance);

            Console.WriteLine("Saldo 2 ->> " + acc2.Balance);
        }
        
    }
}
