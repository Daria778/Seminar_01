// 

int[] array = FillArray(4, 0, 4);
PrintArray(array);
Console.WriteLine();
int[] arrayb = CopyArray(array);
arrayb[0] = 99;
PrintArray(arrayb);
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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)
        Console.Write(arr[i]+", ");
       else
        Console.Write(arr[i]);
    }
    Console.Write("]");
}

int[] CopyArray(int[] arr)
{
    int[] newArr = arr;
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}