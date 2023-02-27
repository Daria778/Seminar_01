// 4, 6, 3 => -4, -6, -3

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

int[] array = FillArray(4, -9, 9);
PrintArray(array);
Console.WriteLine(); 
PosNeg(array);
PrintArray(array);


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

void PosNeg(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
 arr[i] = arr[i] * -1;
}
}