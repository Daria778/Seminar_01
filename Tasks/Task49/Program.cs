// 

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i < arr.GetLength(1) - 1)
        Console.Write(arr[i, j]+", ");
       else
        Console.Write(arr[i, j]);
        }
         Console.WriteLine("]");
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

void Replace(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
        }
    }
}


int [,] array = FillArray(3, 4, 1, 10);
PrintArray(array);
Console.WriteLine();
Replace(array);
PrintArray(array);