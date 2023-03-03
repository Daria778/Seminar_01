// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(Math.Round(arr[i], 1, MidpointRounding.ToZero) + "; ");
        else
            Console.Write(Math.Round(arr[i], 1, MidpointRounding.ToZero));
    }
    Console.Write("]");
}

double Max(double[] arr)
{
    int i = 0;
    double max = arr[i];
while (i < arr.Length)
{
    if(arr[i] > max) max = arr[i];
    i++;
}

return Math.Round(max, 1, MidpointRounding.ToZero);
}

double Min(double[] arr)
{
    int i = 0;
    double min = arr[i];
    while(i < arr.Length)
    {
        if(arr[i] < min) min = arr[i];
        i++;
    }
return Math.Round(min, 1, MidpointRounding.ToZero);
}



double Dif(double[] arr)
{
    double d = 0;
    double i = Max(arr);
    double t = Min(arr);
    d = i - t;
return d;
    
}


double[] array = FillArray(4, -100, 100);
PrintArray(array);
Console.WriteLine();
Console.Write(Dif(array));

