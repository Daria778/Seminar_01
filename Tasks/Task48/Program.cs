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

int[,] FillArray(int rows, int columns)
{
   int[,] arr = new int[rows, columns];
   for (int i = 0; i < arr.GetLength(0); i++)
   {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
         arr[i, j] = i + j;
    }
   } 
   return arr;
}

int [,] array = FillArray(3, 4);
PrintArray(array);