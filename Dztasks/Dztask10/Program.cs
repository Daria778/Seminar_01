// 256 => 5

int number = new Random().Next(100, 1000);
Console.WriteLine($"random number from the segment 100 - 999 => {number}");

double newNumber = NewNumber(number);
Console.WriteLine($"new number from the first received is {newNumber}");

double NewNumber(double num)
{
    double firstDigit = num / 100;
    double secondDigit = firstDigit * 10;
    double x = secondDigit;
    int a;
    a = (int)x;
    double y = firstDigit;
    int c;
    c = (int)y;
    int thirdDigit = c * 10;
    int result = a - thirdDigit;
    return result;
}

