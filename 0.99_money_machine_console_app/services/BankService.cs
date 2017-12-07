using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class BankService
    {
        //THIS FILE TAKES CARE OF MOST OF THE ATM LOGIC AND SYNTHESIZES ALL SERVICES

        //Create instances of services
        private static CustomerService customerService = new CustomerService();
        private static AccountService accountService = new AccountService();
        private static AuthService authService = new AuthService();
        private static TransactionService transactionService = new TransactionService();
        private static DepositService depositService = new DepositService();
        private static WithdrawService withdrawService = new WithdrawService();


        //Start & Login
        private static void ShowHome()
        {
            Console.Title = "ASCII Art";

            string art = @"

                    XXXXXXXXXXXXXXXXXXFEDERAL RESERVE NOTEXXXXXXXXXXXXXXXXXXX
                    XXX  XX       THE UNITED STATES OF AMERICA        XXX  XX
                    XXXX XX  -------       ------------               XXXX XX
                    XXXX XX              /   jJ===-\    \      C7675  XXXX XX
                    XXXXXX     OOO      /   jJ - -  L    \      ---    XXXXXX
                    XXXXX     OOOOO     |   JJ  |   X    |       __     XXXXX
                    XXX    3   OOO      |   JJ ---  X    |      OOOO    3 XXX
                    XXX                 |   J|\    /|    |     OOOOOO     XXX
                    XXX     C36799887   |   /  |  |  \   |      OOOO      XXX
                    XXX                 |  |          |  |       --       XXX
                    XXX      -------    \ /            \ /                XXX
                    X  XX                \ ____________ /               X  XX
                    XX XXX 3_________        --------  ___   _______ 3 XXX XX
                    XX XXX            ___   ONE DOLLAR  i              XXX XX
                    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                                              | |            
                                          __ _| |_ _ __ ___  
                                         / _` | __| '_ ` _ \ 
                                        | (_| | |_| | | | | |
                                         \__,_|\__|_| |_| |_|




                                                             ";
            Console.WriteLine(art);
            Console.WriteLine("                                       Please press enter to begin        ");
            var key = Console.ReadKey();
            if (key.Key != ConsoleKey.Spacebar)
            {
                Console.WriteLine("                    Please press enter to begin        ");
            }
            else
            {
                Console.WriteLine("Great, let's look at the menu.");
                Console.Clear();
            }
        }
        private static void GetCardAndPinMenu()
        {
            Console.Title = "ASCII Art";

            string art = @"

                   __-----__
              ..;;;--'~~~`--;;;..
            /;-~IN GOD WE TRUST~-.\
           //      ,;;;;;;;;      \\
         .//      ;;;;;    \       \\
         ||       ;;;;(   /.|       ||
         ||       ;;;;;;;   _\      ||
         ||       ';;  ;;;;=        ||
         ||LIBERTY | ''\;;;;;;      ||
          \\     ,| '\  '|><| 1995 //
           \\   |     |      \  A //
            `;.,|.    |      '\.-'/
              ~~;;;,._|___.,-;;;~'
                  ''=--'
        ";

            Console.WriteLine(art);
        }
        private static int GetAccountNumber()
        {
            int accountNumber = authService.RequestAccountNumber();
            return accountNumber;
        }
        private static int GetPinNumber()
        {
            int pin = authService.RequestPinNumber();
            return pin;
        }

        //Account Menu Methods
        private static ConsoleKeyInfo ShowAuthorizedAccountMenu()
        {
            Console.Title = "ASCII Art";

            string art = @"
            Main Menu
            Make a Deposit.................................1
            Make a Withdrawl...................................2
            Check Account Balance............................3
            Request Assistance...............................4
            Change Pin.......................................5
            ";
            Console.WriteLine(art);
            Console.WriteLine("Press space bar to see the menu: ");
            var key = Console.ReadKey();
            return key;
        }
        
        //Transaction Methods
        private static int GetKeyFromConsole(ConsoleKeyInfo key)
        {
            if (char.IsDigit(key.KeyChar))
            {
                int keyNumber = int.Parse(key.KeyChar.ToString()); // use Parse if it's a Digit
                return keyNumber;
            }

            return 0;
        }
        
        //Deposit Methods
        private static int DepositMoney(int depositEntered, int transId)
        {
            var totalDeposit = depositService.DepositMoney(depositEntered, transId);
            return totalDeposit;
        }
        private static void ProcessDeposit(int account) {
            Console.Clear();
            int transactionNum = transactionService.CreateTransaction("Deposit", account);
            Console.WriteLine("Let's start your deposit. How much would you like to deposit?");
            var depositString = Console.ReadLine();
            int depositNum = Int32.Parse(depositString);
            int depositResult = DepositMoney(depositNum, transactionNum);
            int balance = accountService.GetBalance(account);
            int newBalance = accountService.AddDepositToBalance(account, depositResult, balance);
            accountService.SaveNewBalanceToDatabase(account, newBalance);
        }

        //Withdraw Methods
        private static int WithdrawMoney(int withdrawEntered, int transId)
        {
            var totalWithdraw = withdrawService.WithdrawMoney(withdrawEntered, transId);
            return totalWithdraw;
        }
        private static void ProcessWithdraw(int account)
        {
            Console.Clear();
            int transactionNum = transactionService.CreateTransaction("Withdraw", account);
            var withdrawString = Console.ReadLine();
            int withdrawNum = Int32.Parse(withdrawString);
            int withdrawResult = WithdrawMoney(withdrawNum, transactionNum);
            int balance = accountService.GetBalance(account);
            int newBalance = accountService.SubtractWithdrawBalance(account, withdrawResult, balance);
            accountService.SaveNewBalanceToDatabase(account, newBalance);

        }

        //ATM Program Method(Authorized)
        public static void RunATM()
        {
            while (true)
            {
                ShowHome();
                GetCardAndPinMenu();
                int account = GetAccountNumber();
                int pin = GetPinNumber();
                bool isAuthed = authService.VerifyUser(account, pin);

                if (isAuthed)
                {
                    var key = ShowAuthorizedAccountMenu();
                    int convertedKey = GetKeyFromConsole(key);
                    //Menu Switch
                    switch (convertedKey)
                    {
                        case 1:
                            ProcessDeposit(account);
                            break;
                        case 2:
                            //End goal: 
                            ProcessWithdraw(account);
                            break;
                        case 3:
                            //TODO: ShowBalance(account);
                            break;
                        case 4:
                            Console.WriteLine("Assistance");
                            break;
                        case 5:
                            Console.WriteLine("Change");
                            break;
                        default:
                            Console.WriteLine("Broken");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                    //TODO: Handle Clear....
                    ShowHome();
                }
                Console.ReadLine();
            }
        }
    }
}
