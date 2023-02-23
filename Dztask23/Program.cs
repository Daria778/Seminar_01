//1, 8, 27, .......

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);

void Square(int num)
{
   int index = 1;
    while(index <= num)
    {
       
       Console.WriteLine($"{index} - {index * index * index}");
       index++;
    }
    return;
}
