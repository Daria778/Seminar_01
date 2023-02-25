// 456 => 46 

int number = new Random().Next(100, 1000);
Console.WriteLine($"random number from the segment 100 - 999 => {number}");

//int firstDigit = number / 100;
//int secondDigit = number % 10;
//int result = firstDigit * 10 + secondDigit;
//Console.WriteLine(result);

int newNumber = NewNumber(number);
Console.WriteLine($"new number from the first received is {newNumber}");

int NewNumber(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}
