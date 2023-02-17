// 10 - 99

int number = new Random().Next(10, 100);
Console.WriteLine($"random number from the segment 10 - 99 => {number}");

//int firstDigit = number / 10;
//int secondDigit = number % 10;

//if (firstDigit > secondDigit)
//Console.WriteLine($"Max digit of the number is {firstDigit}");
//else
//Console.WriteLine($"Max digit of the number is {secondDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Max digit of the number is {maxDigit}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    //if (firstDigit > secondDigit) return firstDigit;
    //return secondDigit;                 ? = тогда    : = иначе
    //int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    //return result;
    return firstDigit > secondDigit ? firstDigit : secondDigit;

}

