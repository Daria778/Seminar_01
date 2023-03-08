// matrix


double[,] FillArray(int rows, int columns, int min, int max)
{
    double[,] arr = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
                Console.Write($"{Math.Round(arr[i, j], 1, MidpointRounding.ToZero), 3}  ");
        }
        Console.WriteLine();
    }
}

double[,] array = FillArray(3, 4, 1, 10);
PrintArray(array);