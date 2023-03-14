// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Enter num M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(Ackerman(numM, numN));

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Ackerman(int n, int m)
{
    if(n == 0) return m + 1;
    else if(m == 0) return Ackerman(n-1, 1);
    else return Ackerman(n - 1, Ackerman(n, m - 1));
}