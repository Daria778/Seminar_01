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

int [,] array = FillArray(3, 4, -100, 100);
PrintArray(array);