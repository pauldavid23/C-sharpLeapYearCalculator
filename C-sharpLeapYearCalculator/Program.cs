// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter year"); 
int year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
    else
    {
        Console.WriteLine(year + " is a leap year.");
    }
}
else
{
    Console.WriteLine(year + " is not a leap year.");
}
