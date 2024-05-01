bool keepGoing;

Console.WriteLine("Welcome to my Number Analyzer!");

Console.WriteLine("Please enter your name");
string userName = Console.ReadLine();

do
{
    int input;
    do
    {
        Console.WriteLine($"{userName}, Please enter an interger from 1 to 100");
        input = int.Parse(Console.ReadLine());

        if (input > 100)
        {
            Console.WriteLine("The number entered was too high.");
        }
        else if (input < 1)
        {
            Console.WriteLine("The number entered was too low");
        }
        else
        {
            break;
        }
    } while (true);


    if (input % 2 == 0)
    {
        if (input > 60)
        {
            Console.WriteLine($"{input} Is even and greater than 60.");
        }
        else if (input >= 26)
        {
            Console.WriteLine($"{input} Is even and between 26 and 60 inclusive.");
        }
        else if (input >= 2 && input <= 24)
        {
            Console.WriteLine($" {input} Is even and less than 25.");
        }
    }
    else
    {
        if (input > 60)
        {
            Console.WriteLine($"{input} Is odd and greater than 60.");
        }
        else if (input < 60)
        {
            Console.WriteLine($"{input} Is odd and less than 60.");
        }
    }

    Console.WriteLine($"{userName}, Would you like to analyze another number?  Enter y to analyze another number, enter anything else to end");
    string input2 = Console.ReadLine();

    if (input2.ToLower() == "y")
    {
        keepGoing = true;
    }
    else
    {
        keepGoing = false;
    }

} while (keepGoing);