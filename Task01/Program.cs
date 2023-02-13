// 
Console.WriteLine("Enter the numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
{
if(numberB == numberA * numberA)
{
    Console.WriteLine($"{numberB} is a square of {numberA}");
}
else
{
    Console.WriteLine($"{numberB} is not a square of {numberA}");
}
}
