// 

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
        Console.WriteLine();
    }
}

void Sort(int[,] arr)
{
    int max = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int n = j + 1; n < arr.GetLength(1); n++)
            {
                if (max < arr[i, j])
                    max = arr[i, j];
            }
            int temp = max;
            max = arr[i, j];
            arr[i, j] = temp;
        }
    }
}


int[,] array = FillArray(3, 4, 1, 10);
PrintArray(array);
Console.WriteLine();
Sort(array);
PrintArray(array);