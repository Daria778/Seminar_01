// n - 1

Console.WriteLine("Enter N ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);

}
if(n > 0) NaturalNumbers(n);
else Console.WriteLine("You have entared the wrong number");
