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

int[,] Matrix(int[,] arr, int[,] newarr)
{   
    int[,] matrix = new int[arr.GetLength(0), newarr.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, j] = matrix[i, j] + arr[i, k] * newarr[k, j];
        
            }
        }
    }
    return matrix;
}

int[,] array = FillArray(2, 2, 1, 10);
int[,] newArray = FillArray(2, 2, 1, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);
Console.WriteLine();
int[,] matrix = Matrix(array, newArray);
PrintArray(matrix);
