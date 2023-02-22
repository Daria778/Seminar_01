// (x;y)

Console.WriteLine("Enter coordinates");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0 
                 ? $"Entered coordinates corespond to {quarter} quarter"
                 : "Entered wrong coordinates";
Console.WriteLine(result);

int Quarter(int x1, int y1)
{
if(x1 > 0 && y1 > 0) return 1;
if(x1 < 0 && y1 > 0) return 2;
if(x1 < 0 && y1 < 0) return 3;
if(x1 > 0 && y1 < 0) return 4;
return 0;
}