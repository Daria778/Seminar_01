// treangle theory

Console.WriteLine("Enter the number A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number B");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number C");
int numberC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ABC(numberA, numberB, numberC));
bool ABC(int numA, int numB, int numC)
{
    if(numA < numB + numC && numB < numA + numC && numC < numA + numB) return true;
    else return false;
   

}