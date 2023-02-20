// week

Console.WriteLine("Enter the number of a day of a week");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 7)
{
if(number == 1) Console.WriteLine("Monday");
else if(number == 2) Console.WriteLine("Tuesday");
else if(number == 3) Console.WriteLine("Wednesday");
else if(number == 4) Console.WriteLine("Thursday");
else if(number == 5) Console.WriteLine("Friday");
else if(number == 6) Console.WriteLine("Saturday");
else if(number == 7) Console.WriteLine("Sunday");

    Weeknum(number);
    if(Weeknum(number)) Console.WriteLine("weekend");
    else Console.WriteLine("weekday");

    bool Weeknum(int num)
    {
       return num == 6 || num == 7; 
    }




}
else
{
    Console.WriteLine("You have entered the wrong number");
}