// multiplicity2.0

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

bool Multiplicity2numbers(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
if(Multiplicity2numbers(number)) Console.WriteLine("Yes");
else Console.WriteLine("No");