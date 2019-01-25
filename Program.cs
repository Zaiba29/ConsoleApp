using System;
/*Declare and use a bool, int, double, char, string, and decimal type.
Implement at least one loop
Implement at least one if or if-else branch with conditions
Implement a switch statement
Implement a simple function calculation (e.g.totalCost or hasEnough)
Use Console.WriteLine and Console.ReadLine
Use string interpolation ($"") and \n or \t
Code must compile and run.
It's more important to practice all the basic programming concepts - if the app is useful or fun, that's great, but not required.
Do not start with any existing application - build it from scratch, on your own, as you will demonstrate throughout the class.*/


namespace ConsoleApp1
{
    class Program
    {
        // public static bool Y { get; private set; }

        static void Main(string[] args)

        {

            Console.WriteLine("welCome to Book store");

            Console.WriteLine("Do you want to buy a book y/n");
            String books=null;

            char inh = Convert.ToChar(Console.ReadLine());

            if (inh == 'y')
            {
                Console.Write("Select book \n");
                Console.Write("java" + "\n" + "Android" + "\n" + "User dessign" + "\n" + ".Net" + "\n");
                books = Console.ReadLine();
            }
            else
            {
                Console.Write("Thanks for visiting");
            }
            //split java,.net,adb

            String[] boo = books.Split(",");
            decimal price = 0;
            decimal Total_price = 0;
            foreach (String book in boo)
            {
               
                switch (book)
                {
                    case "java":
                        price = 10;
                        Console.Write("Book cost is $" + price +"\n");
                       //  Console.ReadKey();
                        break;
                    case "Android":
                      //  int price;
                        price = 15;
                        Console.Write("Book cost is $ " + price +"\n");
                      //  Console.ReadKey();
                        break;
                    case "User design":
                        //  double price3;
                        price = 10;
                        Console.Write("Book cost is $ " + price);
                        break;
                    case ".Net":
                    //    int price4;
                        price = 17;
                        Console.Write("Book price is $ " + price);
                    defaut:
                        Console.Write("Book cost is $5");
                        break;
                }
                Total_price = Total_price + price;
               

            }
            Console.WriteLine("Total price of the books is" + Total_price);
            Console.ReadKey();



        }
           // Console.ReadLine();
        }
    }

