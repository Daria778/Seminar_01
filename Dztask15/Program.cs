// week

Console.WriteLine("Enter the number of a day of a week");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 7)
{
    int result = Weeknum(number);
    if(Weeknum(number) >= 6) Console.WriteLine("Weekend");



}
else
{
    Console.WriteLine("You have entered the wrong number");
}