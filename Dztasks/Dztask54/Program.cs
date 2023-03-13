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

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = j;
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                if (arr[i, n] > max)  max = n;
            
            for (int h = j + 1; h < arr.GetLength(1); h++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[i, max];
                arr[i, max] = temp;
            }
            }
            
        }
    }

}
    int[,] array = FillArray(4, 4, 1, 10);
    PrintArray(array);
    Console.WriteLine();
    Sort(array);
    PrintArray(array);