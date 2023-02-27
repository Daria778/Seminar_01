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

int[] array = FillArray(12, -9, 9);

PrintArray(array);
Console.WriteLine();
int[] sumNegPosE = GetSumPosNegE(array);
Console.WriteLine($"Sum of pos is {sumNegPosE[1]}, sum of neg is {sumNegPosE[0]}");



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

int[] GetSumPosNegE(int[] arr)
{
  int sumNeg = 0;
  int sumPos = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] < 0) sumNeg += arr[i];
    else sumPos += arr[i];
  }
  return new int[]{sumNeg, sumPos};
}
