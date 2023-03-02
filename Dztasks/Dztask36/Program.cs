// [3, 7, 23, 12] -> 19

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] array = FillArray(4, -100, 100);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(SumOdd(array));

int SumOdd(int[] arr)
{
    int sum = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) sum = sum + arr[i];

    }
return sum;
}

void PrintArray(int[] arr)
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