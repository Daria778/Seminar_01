// (x, y) 1, 2, 3, 4

Console.WriteLine("Enter the quarter");
Console.Write("quarter: ");
int q = Convert.ToInt32(Console.ReadLine());


string xy = XY(q);
string result = xy == "0" ? 
               "You have entered the wrong number for quarter"
               : $"range of possible coordinates of points in a quarter {q} is {xy}";
               Console.WriteLine(result);
           
string XY(int q)
{
if(q == 1) return "x > 0, y > 0";
if(q == 2) return "x < 0, y > 0";
if(q == 3) return "x < 0, y < 0";
if(q == 4) return "x > 0, y < 0";
return "0";
}
