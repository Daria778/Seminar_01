// Average

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

double[] Average(int[,] arr)
{
    double average = 0;
    double sum = 0;
    double[] newarr = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        average = sum / arr.GetLength(1);
       
         newarr[j] = Math.Round(average, 1, MidpointRounding.ToZero);
        sum = 0;
    }
    return newarr;
}

void PrintNewArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ";  ");
        else
            Console.Write(arr[i]);
    }
    Console.Write("]");
}

int[,] array = FillArray(4, 4, 1, 10);
PrintArray(array);
Console.WriteLine();
PrintNewArray(Average(array));
