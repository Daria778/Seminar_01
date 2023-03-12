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


void ReplaceColumnsRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            int replace = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = replace;
        }
    }
}

int[,] array = FillArray(3, 3, 1, 10);
PrintArray(array);
Console.WriteLine();
int rows = array.GetLength(0);
int columns = array.GetLength(1);
ReplaceColumnsRows(array);
if (rows != columns) Console.WriteLine($"input error");
PrintArray(array);