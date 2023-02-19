// 356 => 6

int number = new Random().Next();
Console.WriteLine($"random number => {number}");

while(number > 999)
{
    number = number / 10;
}
Console.WriteLine(number);

int thirdDigit = ThirdDigit(number);
Console.WriteLine($"Max digit of the number is {thirdDigit}");

int ThirdDigit(int num)
{
    int digit = num % 10;
    return digit;

}