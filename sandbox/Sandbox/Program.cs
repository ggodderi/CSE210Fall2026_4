using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {

        // string x = "This a string with 234234234";
        Console.Write("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Circle myCircle = new Circle();

        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);

        Circle myCircle2 = new Circle();

        myCircle2._radius = 10;

        double area2 = myCircle2.GetArea();

        Console.WriteLine(area);
    }
}



















    // static double AddNumbers(double x, int y)
    // {
    //     // Console.WriteLine(x);
    //     return x + y;
    // }

    // static string MyName()
    // {
    //     return "Bob";
    // }

    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, its nice to meet you");
    // }

        // string myName = MyName();
        // DisplayGreeting(myName);
        // double total = AddNumbers(12.234, 20);
        // Console.WriteLine(total);
        // int x = 10;
        // int y = 30;
        // int z = 40;
        // if ((x == 10 || y == 30) && z == 30) 
        // {
        //     Console.WriteLine("X is 10");
        //     Console.WriteLine("Y is fun");
        // }
        // else if (x == 20)
        // {
        //     Console.WriteLine("X is 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default output");
        // }

        // string numberString = "123";
        // int myNumber = int.Parse(numberString);

        // While Loops

        // bool done = false;

        // while  (! done)
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }



        // bool done;

        // do 
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y";
        // } while  (! done);

        // double i = 0;
        // for(i = 0; i < 1.0; i += 0.01)
        // {
        //     Console.WriteLine(i);
        // }


        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};

        // myFriends.Add("Doug");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }

        // For loop

        // Lists List<int> = new List<int>()

        // Functions
//     }
// }