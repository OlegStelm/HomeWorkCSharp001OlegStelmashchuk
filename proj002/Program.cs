int a;
int b;
int c;

Console.WriteLine("enter a number 'a'");
int.TryParse(Console.ReadLine(), out a);

Console.WriteLine("enter a number 'b'");
int.TryParse(Console.ReadLine(), out b);

Console.WriteLine("enter a number 'c'");
int.TryParse(Console.ReadLine(), out c);

if (a==b && a==c && c==b)
{
    Console.Write("The numbers are equal!");
}
else
{
int max=a;
if(a>max)max=a;
if(b>max)max=b;
if(c>max)max=c;

Console.Write("max=");
Console.WriteLine(max);
}
