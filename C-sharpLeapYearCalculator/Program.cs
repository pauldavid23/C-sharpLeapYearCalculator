// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter year"); 
int year = Convert.ToInt32(Console.ReadLine());

bool isLeapYear = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
Console.WriteLine(year + (isLeapYear ? " is a leap year." : " is not a leap year."));
Console.ReadKey(); 
