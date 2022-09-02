Console.Write("Write first number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Write third number: ");
int t = Convert.ToInt32(Console.ReadLine());

int max = n;

if (n<m) max=m;
if (m<t) max=t;
Console.WriteLine(max);