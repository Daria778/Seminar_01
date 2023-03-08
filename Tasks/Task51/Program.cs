// 

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

int Sum(int[,] arr)
{
    int sum = 0;
    //int size = arr.GetLength(0);
    //if ( size < arr.GetLength(1)) size = arr.GetLength(1);
    for (int i = 0; i < arr.GetLength(0) && i < arr.GetLength(1); i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

int[,] array = FillArray(89, 8, 1, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(Sum(array));
