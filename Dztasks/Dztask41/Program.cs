// 

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an array");

int[] array = FillArray(number);
Console.WriteLine("Your array:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine(MoreNull(array));

int[] FillArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return arr;
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

int MoreNull(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}