Console.WriteLine("Write numbers1: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write numbers2: ");
int m=Convert.ToInt32(Console.ReadLine());
int max = n;
int min = m;

if (n>m) {
    max = n;
    min = m;
    }
if (n<m) {
    max = m;
    min =n;
    }
Console.WriteLine(max);
Console.WriteLine(min);