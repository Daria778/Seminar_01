// 

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

int[] array = FillArray(123, 0, 210);
Console.WriteLine("Your array:");
PrintArray(array);
Console.WriteLine();
int findArray = Findarray(array);
Console.Write("The number of two-digit numbers is ");
Console.WriteLine(findArray);


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

int Findarray( int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99)
        count++;
        
    }
    return count;
}