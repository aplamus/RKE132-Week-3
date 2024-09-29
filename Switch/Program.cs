int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0-6

switch (weekDay) //väärtus mida kontrollitakse
{
    case 0: // case 0: == if(weekDay == 0)
        Console.WriteLine("It's sunday!");
        break;
    case 1:
        Console.WriteLine("It's monday");
        break;
    case 2:
        Console.WriteLine("It's tuesday");
        break;
    case 3:
        Console.WriteLine("It's wednesday");
        break;
    case 4:
        Console.WriteLine("It's thursday");
        break;
    case 5:
        Console.WriteLine("It's friday");
        break;
    case 6:
        Console.WriteLine("It's saturday");
        break;
    default:
        Console.WriteLine("Oops. Your calendar must be broken.");
        break;
}

Console.WriteLine("Have a nice day!");
