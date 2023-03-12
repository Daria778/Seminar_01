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

int[] Newarray(int[,] arr)
{
    int n = 0;
    int size = arr.GetLength(0) * arr.GetLength(1);
    int[] newarr = new int[size];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
            newarr[n] = arr[i, j];
            n += 1;
       }
    }
    return newarr;
}

void PrintNewArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.Write(arr[i]);
    }
    Console.Write("]");
}

void SumElem(int[] newarr)
{
    int count = 1;
    int curentNum = newarr[0];
    for (int i = 1; i < newarr.Length; i++)
    {
        if(newarr[i] == curentNum) count++;
        else
        {
            Console.WriteLine($"number {curentNum} meets {count} times");
            curentNum = newarr[i];
            count = 1;
        }
    }
}


int[,] array = FillArray(3, 3, 1, 10);
PrintArray(array);
Console.WriteLine();
int[] newarray = Newarray(array);
PrintNewArray(newarray);
Array.Sort(newarray);
Console.WriteLine();
PrintNewArray(newarray);
Console.WriteLine();
SumElem (newarray);
