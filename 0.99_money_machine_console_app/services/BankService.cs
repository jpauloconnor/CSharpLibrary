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
        public static CustomerService customerService = new CustomerService();
        public static AccountService accountService = new AccountService();
        public static AuthService authService = new AuthService();
        public static TransactionService transactionService = new TransactionService();
        public static DepositService depositService = new DepositService();

        //Start & Login
        #region
        public static void ShowHome()
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
            Console.WriteLine("Press space bar to see the menu: ");
            var key = Console.ReadKey();
            if (key.Key != ConsoleKey.Spacebar)
            {
                Console.WriteLine("Please press the spacebar");
            }
            else
            {
                Console.WriteLine("Great, let's look at the menu.");
                Console.Clear();
            }
        }
        public static void GetCardAndPinMenu()
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
        public static int GetAccountNumber()
        {
            int accountNumber = authService.RequestAccountNumber();
            return accountNumber;
        }
        public static int GetPinNumber()
        {
            int pin = authService.RequestPinNumber();
            return pin;
        }
        #endregion


        //Account Menu Methods
        #region
        public static ConsoleKeyInfo ShowAuthorizedAccountMenu()
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
        public static int GetKeyFromConsole(ConsoleKeyInfo key)
        {
            if (char.IsDigit(key.KeyChar))
            {
                int keyNumber = int.Parse(key.KeyChar.ToString()); // use Parse if it's a Digit
                return keyNumber;
            }

            return 0;
        }
        //public static int CreateTransaction(string transType, int accountNum)
        //{
        //    transactionService.CreateTransaction(transType, accountNum);
        //    return accountNum;
        //}
        #endregion  
        //Deposit Methods
        public static int DepositMoney(int depositEntered, int transId)
        {
            var totalDeposit = depositService.DepositMoney(depositEntered, transId);
            return totalDeposit;
        }


        //Withdraw Methods
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
                    //MENU Options
                    var key = ShowAuthorizedAccountMenu();
                    int convertedKey = GetKeyFromConsole(key);
                    //Menu Switch
                    switch (convertedKey)
                    {
                        case 1:
                            Console.Clear();
                            int transactionNum = transactionService.CreateTransaction("Deposit", account);
                            Console.WriteLine("Let's start your deposit. How much would you like to deposit?");
                            var depositString = Console.ReadLine();
                            int depositNum = Int32.Parse(depositString);
                            int depositResult = DepositMoney(depositNum, transactionNum);
                            int balance = accountService.GetBalance(account);
                            //int totalDeposit = depositResult + balance;
                            int newBalance = accountService.AddDepositToBalance(account, depositResult, balance);
                            //Add deposit amount to account
                            accountService.SaveNewBalanceToDatabase(account, newBalance);
                            break;
                        case 2:
                            Console.WriteLine("Withdrawl");
                            break;
                        case 3:
                            Console.WriteLine("Balance");
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
                    //See Balance
                    //Withdrawl Cash
                    //Deposit Cash
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
