// max among 3
Console.WriteLine("Enter the numberA");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the numberB");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the numberC");
int numC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your numbers are {numA}, {numB}, {numC}");
if(numA > numB && numA > numC)
{
    Console.WriteLine($"max number is {numA}");
}
else if(numB > numA && numB > numC)
{
    Console.WriteLine($"max number is {numB}");
}
else if(numC > numA && numC > numB)
{
    Console.WriteLine($"max number is {numC}");
    
}