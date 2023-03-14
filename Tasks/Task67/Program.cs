// 453 -> 12, sum
Console.WriteLine("Enter a number ");
int number = Convert.ToInt32(Console.ReadLine());


int SumNumbers(int n)
{
if (n == 0) return n;
else return n % 10 + SumNumbers(n / 10); // 453 / 10, 45 / 10, 4 / 10(save in stack) call is first always!!!
                                         // 4 + 5 + 3 
}

Console.WriteLine(SumNumbers(453));
