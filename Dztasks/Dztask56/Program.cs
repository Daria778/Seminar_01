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

int[,] Sum(int[,] arr)
{ 
    int[,] arrsum = new int[arr.GetLength(0), 1];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }

        arrsum[i, 0] = sum;


        sum = 0;
    }
    return arrsum;
}

int MinSum(int[,] arr)
{
    int min = arr[0, 0];
    int minI = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < min)
            {
            min = arr[i, j];
            minI = i;
            }
        }
    }
    return minI + 1;
}

int[,] array = FillArray(3, 3, 1, 10);
PrintArray(array);
Console.WriteLine();
int[,] sumArr = Sum(array);
PrintArray(sumArr);
Console.WriteLine($"{MinSum(sumArr)} строка");