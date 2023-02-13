// %

Console.WriteLine("Enter a three-digit number");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100 && num <= 999)
{
    int lastNumber = num % 10;
    Console.WriteLine(lastNumber);
}
else
{
    Console.WriteLine("You have entered an incorrect number");
}