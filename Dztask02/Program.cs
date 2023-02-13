// max or not?

Console.WriteLine("Enter the numberA");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the numberB");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    int max = numberA;
    Console.WriteLine($"{max} > {numberB}");
}
else
{
    int max = numberB;
    Console.WriteLine($"{max} > {numberA}");
}
