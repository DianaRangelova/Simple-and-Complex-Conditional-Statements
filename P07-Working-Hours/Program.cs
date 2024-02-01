int hourOfTheDay = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

if ((hourOfTheDay >= 10 && hourOfTheDay <= 18) && dayOfTheWeek != "Sunday")
{
    Console.WriteLine("open");
}    

else
{
    Console.WriteLine("closed");
}

