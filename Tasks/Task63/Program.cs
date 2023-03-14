// 1 - N

Console.WriteLine("Enter N ");
int n = int.Parse(Console.ReadLine());

void NaturalNumbers(int num)
{
    if(num == 0) return;
    NaturalNumbers(num -1);
    Console.Write($"{num} ");
}

NaturalNumbers(n);