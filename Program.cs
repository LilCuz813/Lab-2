using System;

Console.WriteLine("Please enter your name.");
string name = (Console.ReadLine());

bool runDoWhile = true;
do
{
    Console.WriteLine("Please enter a integer between 1 and 100.");
    int num1 = int.Parse(Console.ReadLine());

    if (num1 % 2 == 1 && num1 < 60)
    {
        Console.WriteLine("The number " + num1 + " is odd and less than 60 " + name);
    }
    if (num1 % 2 == 0 && num1 >= 2 && num1 <= 24)
    {
        Console.WriteLine("The number " + num1 + " is even and less than 25 " + name);
    }
    if (num1 % 2 == 0 && num1 >= 26 && num1 <= 60)
    {
        Console.WriteLine("The number " + num1 + " is even and between 26 and 60 inclusive ." + name);
    }
    if (num1 % 2 == 0 && num1 > 60)
    {
        Console.WriteLine("The number " + num1 + " is even and greater than 60 ." + name);
    }
    if (num1 % 2 == 1 && num1 > 60)
    {
        Console.WriteLine("The number " + num1 + " is odd and greater than 60 ." + name);
    }

    Console.WriteLine("While the program is still running...");
    Console.WriteLine("Would you like to try again? Enter y/n");
    string choice = Console.ReadLine();
    runDoWhile = choice == "y";

} while (runDoWhile);

