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
    }
}

void ReplaceArray(int[,] arr)
{
    int firstRow = 0;
    int lastRow = arr.GetLength(0) - 1;
    for (int j = 0; j < arr.GetLength(1); j++)
    {

        int replace = arr[firstRow, j];
        arr[firstRow, j] = arr[lastRow, j];
        arr[lastRow, j] = replace;

    }
}

int[,] array = FillArray(5, 5, 1, 10);
PrintArray(array);
Console.WriteLine();
ReplaceArray(array);
PrintArray(array);