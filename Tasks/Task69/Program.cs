//  3 -> 27

Console.WriteLine("Enter num A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num B");
int numB = Convert.ToInt32(Console.ReadLine());
if(numB < 0) Console.WriteLine("You have entared the wrong number");
else 
Console.WriteLine($"{DegreeOfNum(numA, numB)} ");

int DegreeOfNum(int num1, int num2)
{
   if(num2 == 0) return num1;
   //else if(num2 % 2 == 0 ) return DegreeOfNum(num1 * num1, num2 / 2);
   else return num1 * DegreeOfNum(num1, num2 - 1);
   //else return DegreeOfNum(num1, num2 -1) * num1;
   
}
