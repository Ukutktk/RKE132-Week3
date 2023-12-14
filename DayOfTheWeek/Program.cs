

using System.Collections.Concurrent;

int Weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(Weekday);

if (Weekday == 0)
{
    Console.WriteLine("It's Sunday ");
}
else if (Weekday == 1)
{
    Console.WriteLine("It's Monday");
}
else if (Weekday == 2)
{
    Console.WriteLine("It's Tuesday");
}
else if(Weekday == 3)
{
    Console.WriteLine("It's Wednesday");
}
else if (Weekday == 4)
{
    Console.WriteLine("It's Thrusday");
}
else if (Weekday == 5)
{
    Console.WriteLine("It's Friday");
}
else if (Weekday == 6)
{
    Console.WriteLine("It's Saturday");
}

Console.WriteLine("Have a nice day");