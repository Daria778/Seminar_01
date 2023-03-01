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

int[] array = FillArray(13, 1, 10);
PrintArray(array);
Console.WriteLine();
int[] newArray = ProductOfNumbers(array);
PrintArray(newArray);


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

int[] ProductOfNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if(arr.Length % 2 != 0)
    size += 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
     return newArr;
}