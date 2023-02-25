// 

int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] ar)
{
    for (int pos = 0; pos < ar.Length; pos++)
    {
        Console.Write(ar[pos]+" ");
       
    }
}



