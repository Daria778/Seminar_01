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

