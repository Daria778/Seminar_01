// 956 = 3, 1275 = 4....

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int digits = Digits(number);
Console.WriteLine(digits);

int Digits(int num)
{
    int result = 0;
    while(num != 0)
    {
        num = num / 10;
        result++;
    }
    return result;
}