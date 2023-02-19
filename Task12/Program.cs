// multiplicity
Console.WriteLine();
Console.WriteLine("Remember, that the first number must be more than the second number");
Console.WriteLine();

Console.WriteLine("Enter the first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber >= secondNumber)
{

int result = Multiplicity(firstNumber, secondNumber);
if (result == 0) Console.WriteLine($"{firstNumber} is multiple of {secondNumber}");
else Console.WriteLine($"{firstNumber} is not multiple of {secondNumber}, the remainder is {result}");


int Multiplicity(int num1, int num2)
{
    return num1 % num2;

}
}
else
{
    Console.WriteLine("Are you stupid?");
}

