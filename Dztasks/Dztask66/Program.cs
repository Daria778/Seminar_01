// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Enter num M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(numM <= 0 && numN <= 0) Console.WriteLine("You have entered the wrong numbers");
else
Console.WriteLine($"{SumNumbers(numM, numN)}");

int SumNumbers(int num1, int num2)
{
    if(num1 == num2) return num1;
    else if(num2 > num1) return num1 + SumNumbers(num2, num1 + 1);
    else return num2 + SumNumbers(num1, num2 + 1);
}