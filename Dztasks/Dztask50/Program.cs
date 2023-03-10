// i, j

int[,] array = FillArray(4, 4, 1, 10);
PrintArray(array);

Console.WriteLine("Enter i");
int numi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter j");
int numj = Convert.ToInt32(Console.ReadLine());


if(numi > 0 && numj > 0 
   && numi < array.GetLength(0) && numj < array.GetLength(1)) Console.WriteLine(array[numi, numj]);
else Console.WriteLine("there is no such element in the array");

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
                Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}
