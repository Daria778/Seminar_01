// 45 -> 101101

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AB(number));

string AB(int num)
{
    string count = "";

    while(num != 0)
   {
    count = num % 2 + count;
    num = num / 2;
   }
   
   return count;
}

// решение через int
int FF(int num)
{
    int count = 1;
    int result = 0;
    while(num > 0)
    {
        result = result + num % 2 * count;
        num = num / 2;
        count *= 10;
    }
    return result;
}