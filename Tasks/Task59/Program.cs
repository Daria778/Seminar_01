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

int[] FindMin(int[,] arr)
{
    int row = 0;
    int column = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] <= arr[row, column])
            {
                row = i;
                column = j;
            }
        }
    }
    return new int[] { row, column };
}

int[,] Delete(int[,] arr, int[] newarr)
{
    int[,] matrix = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (m == newarr[0]) m++;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (n == newarr[1]) n++;
            matrix[i, j] = arr[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return matrix;
}

int[,] array = FillArray(3, 3, 1, 10);
PrintArray(array);
Console.WriteLine();
int[] find = FindMin(array);
int[,] newarray = Delete(array, find);
PrintArray(newarray);