/*C# Summative Assessment - THE FINAL FIDDLE(For now)
Do your best on this assessment. Get as far as you can in 120 minutes. 
Note that we will consider partial answers, so if your code is close and not working, feel free to comment out your answer.
Feel free to reference any other work you've done or refer to online resources to complete your answers. 

Please PUT A NUMBERED COMMENT in the general vicinity of your answer so that we know where you're answering the question. 
The first answer is completed in this fashion.
*/

//PART ONE: A few Basics
/*1 Declare and initialize 5 different types. Int, Boolean, String, Double, Decimal*/
/*2 Write a function that takes two of your variables from #1 and concatenates them into a string. 
	Print the string to the console. Be sure to call the function. My function prints this to the:
	"I have been happily married to Laurissa for 5 years." */
/*3 Create an array of strings, a simple array of 3-5 names of your closest friends will do. 
	Loop over the array and print it to the console. */

//PART TWO: OOP stuff
/*4 Create a class called Customer class. The class should have two properties, Name and Purchase. 
	You should also create an Enum for that class that is called GenderType. The 0 spot should be Male, 
	the 1 spot should be Female, and the 2 spot should be undefined.*/
/*5 Create a constructor in the class that allows you to more easily create Customer objects. 
	The constructor should have name, purchase, and gender parameters. Remember that gender will be an enum, so the enum
	name will be its type.*/
/*6 Create a method in your Customer class that sends a thank you to the customer after their purchase.  
	Your console message might read something like this:
	"Hello PAUL, thank you for purchasing the FENDER JAZZ GUITAR. We hope you enjoy it. 
	NOTE: The caps are used to indicate where your variable names might go in your string.*/
/*7 Create two more methods. They should both be called SendSaleNotice. One should have no parameters and one is 
	an overload of that same method. It should have a string item as a parameter. Use these methods to announce sales. 
	Your methods should print something similar to this message:
	Hello Paul, We wanted to let you know there's a sale coming up on 4/1/2016.
	Hello Paul, We wanted to let you know there's a sale on Apple iPhones coming up on 4/1/2016.*/
/*8 Create a subclass of Customer called InactiveCutomer. The class should have an int property called MonthsInactive, and other programmers
	SHOULD NOT be able to create subclasses from it.*/
/*9 In the InactiveCustomer subclass, create a constructor that uses the base keyword that adds a monthsInactive parameter. */
/*10 In the InactiveCustomer subclass create a method that sends a message to a customer who has been inactive for over
	four months. The console would read something like this:
	"Thanks for shopping with us GAVIN. We saw that you purchased an IMAC from us 5 MONTHS AGO. We'd like to know if you'd 
	like to take a look at some of our current deals."*/
/*11 You should, of course, create objects for these classes, set the properites in the parenthesis,
	and test the methods on those objects.*/
/*12 Add a method to the Customer class called PrintCustomerInfo. The method should print the name, 
	purchase, and gender of the customer. 
	It could go like this: Paul - Fender Jazz Bass Guitar - Male. NOTE: You should be able to override this method.
/*14 Add an enum to the InactiveCustomer class that gives a couple reasons why a customer might not be purchasing. The reasons might be Irate, Moved, Uninterested*/
/*15 Add a method called PrintCustomerInfo that overrides the one from the Customer class.
	You should print Name, product purchased, gender, months inactive, and reason for inactivity.
	Michael - desk - Male - 4 - Moved*/

//PART III: Bonus
/* Bonus Idea #1: Create a PreferredCustomer class that includes a custom method made by you. */
/* Bonus Idea #2: Do any other showing off that you'd like to do here. If you have extra time, you should do as much as you can to show your chops. 
Overdelivering is a great trait in a developer. Most of the time, the customers will be ecstatic to see that you went above and beyond.*/

//NOTE: This is a Script application, and you won't need a Main function.  


using System;

//PART ONE
string example = "example answer"; //1

//PART ONE: A few Basics
/*1 Declare and initialize 5 different types. Int, Boolean, String, Double, Decimal*/

int number = 5;
bool boolean = true;
string name = "Jordan";
double otherNumber = 4.5678493D;
decimal dollar = 4.31M;

/*2 Write a function that takes two of your variables from #1 and concatenates them into a string. 
	Print the string to the console. Be sure to call the function. My function prints this to the:
	"I have been happily married to Laurissa for 5 years." */

public void concat()
{
    Console.WriteLine("My name is {0} and that is the truth: {1}", name, boolean);
}

concat();
Console.WriteLine("");

/*3 Create an array of strings, a simple array of 3-5 names of your closest friends will do. 
	Loop over the array and print it to the console. */

string[] friendsNames = { "Nick", "Troy", "Evan", "Chris", "Pat" };

foreach (string name in friendsNames)Console.WriteLine(name);

//PART TWO
	
	//CREATE OBJECTS HERE

	//CREATE CLASS HERE

	//CREATE SUBCLASS HERE

/*4 Create a class called Customer class. The class should have two properties, Name and Purchase. 
	You should also create an Enum for that class that is called GenderType. The 0 spot should be Male, 
	the 1 spot should be Female, and the 2 spot should be undefined.*/



public class Customer
{

    public string Name { get; set; }
    public string Purchase { get; set; }

    public enum GenderType
    {
        Male,
        Female,
        Undefined
    };


    //*5 below

    public Customer(string name, string purchase, GenderType gender)
    {
        this.Name = name;
        this.Purchase = purchase;
        this.Gender = gender;
    }

    public GenderType Gender { get; set; }

    //*6 below

    public void ThankYou()
    {
        Console.WriteLine("Hello {0}, thank you for purchasing a {1}. We know you will enjoy it.", this.Name, this.Purchase);
    }

    //*7 first 7 below

    public void SendSaleNotice()
    {
        Console.WriteLine("Hello {0}, we wanted to let you know there's a sale coming up on 4/1/2016.", this.Name);
    }

    public void SendSaleNotice(string item)
    {
        Console.WriteLine("Hello {0}, we wanted to let you know there's a sale on {1} coming up on 4/1/2016.", this.Name, item);
    }

    //*11 Below

    public virtual void PrintCustomerInfo()
    {
        Console.WriteLine("{0} - {1} - {2}", this.Name, this.Purchase, this.Gender);
    }
}





/*5 Create a constructor in the class that allows you to more easily create Customer objects. 
	The constructor should have name, purchase, and gender parameters. Remember that gender will be an enum, so the enum
	name will be its type.*/
/*6 Create a method in your Customer class that sends a thank you to the customer after their purchase.  
	Your console message might read something like this:
	"Hello PAUL, thank you for purchasing the FENDER JAZZ GUITAR. We hope you enjoy it. 
	NOTE: The caps are used to indicate where your variable names might go in your string.*/
/*7 Create two more methods. They should both be called SendSaleNotice. One should have no parameters and one is 
	an overload of that same method. It should have a string item as a parameter. Use these methods to announce sales. 
	Your methods should print something similar to this message:
	Hello Paul, We wanted to let you know there's a sale coming up on 4/1/2016.
	Hello Paul, We wanted to let you know there's a sale on Apple iPhones coming up on 4/1/2016.*/



/*8 Create a subclass of Customer called InactiveCutomer. The class should have an int property called MonthsInactive, and other programmers
	SHOULD NOT be able to create subclasses from it.*/

private class InactiveCustomer : Customer
{
    int MonthsInactive;

    //*8 below

    public InactiveCustomer(string Name, string Purchase, GenderType Gender, int monthsInactive, Reasons reason) : base(Name, Purchase, Gender)
    {
        this.MonthsInactive = monthsInactive;
        this.Reason = reason;
    }

    //*9 Below

    public void overFourMonths()
    {
        if (MonthsInactive > 4)
            Console.WriteLine("Thanks for shopping with us {0}. We saw that you purchased a {1} from us {2} months ago. We'd like to know if you'd like to take a look at some of our current deals.", this.Name, this.Purchase, this.MonthsInactive);
    }

    //*12 Below

    public enum Reasons { Irate, Moved, Uninterested };

    public Reasons Reason { get; set; }

    //*13 Below

    public override void PrintCustomerInfo()
    {
        Console.WriteLine("{0} - {1} - {2} - {3} - {4}", this.Name, this.Purchase, this.Gender, this.MonthsInactive, this.Reason);
    }
}

/*8 In the InactiveCustomer subclass, create a constructor that uses the base keyword that adds a monthsInactive parameter. */
/*9 In the InactiveCustomer subclass create a method that sends a message to a customer who has been inactive for over
	four months. The console would read something like this:
	"Thanks for shopping with us GAVIN. We saw that you purchased an IMAC from us 5 MONTHS AGO. We'd like to know if you'd 
	like to take a look at some of our current deals."*/
/*10 You should, of course, create objects for these classes, set the properites in the parenthesis,
	and test the methods on those objects.*/

Customer fred = new Customer("Fred", "Windows 10 ultimate machine", Customer.GenderType.Undefined);
Customer michael = new Customer("Michael", "Patriots crap", Customer.GenderType.Male);
Customer dion = new Customer("Dion", "Printer accessories", Customer.GenderType.Female);

Customer bobbi = new InactiveCustomer("Bobbi", "Gravity Desk", Customer.GenderType.Female, 7, InactiveCustomer.Reasons.Moved);

Console.WriteLine("");
fred.ThankYou();

fred.SendSaleNotice();
fred.SendSaleNotice("more great windows 10 computers");

fred.PrintCustomerInfo();
bobbi.PrintCustomerInfo();
/*11. Add a method to the Customer class called PrintCustomerInfo. The method should print the name, 
	purchase, and gender of the customer. 
	It could go like this: Paul - Fender Jazz Bass Guitar - Male. NOTE: You should be able to override this method.
/*12. Add an enum to the InactiveCustomer class that gives a couple reasons why a customer might not be purchasing. The reasons might be Irate, Moved, Uninterested*/
/*13. Add a method called PrintCustomerInfo that overrides the one from the Customer class.
	You should print Name, product purchased, gender, months inactive, and reason for inactivity.
	Michael - desk - Male - 4 - Moved*/