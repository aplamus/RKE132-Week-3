
using System.ComponentModel.Design;

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.WriteLine("It's Sunday!");
}
else if (weekDay == 1)
{
    Console.WriteLine("It's monday");
}
else if (weekDay == 2)
{
    Console.WriteLine("It's tuesday");
}
else if (weekDay == 3)
{
    Console.WriteLine("It's wednesday");
}
else if (weekDay == 4)
{
    Console.WriteLine("It's thursday");
}
else if (weekDay == 5)
{
    Console.WriteLine("It's friday");
}
else
{
    Console.WriteLine("It's saturday");
}

Console.WriteLine("Have a nice day!");
