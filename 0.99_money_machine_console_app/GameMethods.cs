using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class GameMethods
    {
        //Create instances of services
        public static CustomerService customerService = new CustomerService();
        public static AccountService accountService = new AccountService();
        public static AuthService authService = new AuthService();

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
            int accountNumber = accountService.RequestAccountNumber();
            return accountNumber;
        }
        public static int GetPinNumber()
        {
            int pin = accountService.RequestPinNumber();
            return pin;
        }
            //    Console.WriteLine("Please enter your pin");
            //    string pinNumber = Console.ReadLine();
            //    int pinNumberConverted = Int32.Parse(pinNumber);

            //    accountService.LogInUser(accountNumber, pinNumberConverted);
            //}


            /// <summary>
            /// RunATM
            /// </summary>
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
                    //PHASE #2 - Unauthenticated User options

                    //TODO: Option #1 - Swipe your card to log in to account + enter pin.
                    Console.WriteLine("Please swipe your card?");
                    var accountNumber = Console.ReadLine();
                    Console.WriteLine("What is your pin?");
                    var enteredPin = Console.ReadLine();
                    /*TODO: LogInService - write a method that takes in a pin
                        Check if the user already exists.
                        If users exists and pin is correct, log them in.
                   */

                    //Option #2 - Sign up/create a new customer.
                    Console.WriteLine("Create a new customer. First Name.");
                    var first = Console.ReadLine();
                    Console.WriteLine("Create a new customer. Last Name.");
                    var last = Console.ReadLine();

                    customerService.CreateCustomer(first, last);
                    Console.WriteLine("What is your customer ID?");
                    var customerID = Console.ReadLine();
                    int convertedCustomerID = Int32.Parse(customerID);
                    customerService.GetCustomerID(convertedCustomerID);
                    accountService.CreateAccount("Checking", convertedCustomerID);

                    //TODO: Option #2 Part #2 - Create a new account for a brand new customer.
                    Console.WriteLine("Hello {0} you like to create a new account?");
                    var type = Console.ReadLine();
                    //TODO: Option #4 - See member benefits.
                    //PHASE 3 - Transactional things and other things logged in
                    Console.WriteLine("What kind of transaction would you like to make?");
                    //TODO: Give options for return users.
                    var transactionChoices = Console.ReadLine();
                    Console.WriteLine("How much would you like to withdrawl?");
                    Console.WriteLine("Will you be depositing cash or checks?");
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
