int a1=5;
int b1=7;

int max1=a1;
if(a1>max1)max1=a1;
if(b1>max1)max1=b1;

Console.Write("1. max=");
Console.WriteLine(max1);

int a2=2;
int b2=10;

int max2=a2;
if(a2>max2)max2=a2;
if(b2>max2)max2=b2;

Console.Write("2. max=");
Console.WriteLine(max2);

int a3=-9;
int b3=-3;

int max3=a3;
if(a3>max3)max3=a3;
if(b3>max3)max3=b3;

Console.Write("3. max=");
Console.WriteLine(max3);

int a;
int b;

Console.WriteLine("enter a number 'a'");
int.TryParse(Console.ReadLine(), out a);

Console.WriteLine("enter a number 'b'");
int.TryParse(Console.ReadLine(), out b);

if (a==b)
{
    Console.Write("The numbers are equal!");
}
else
{
int max=a;
if(a>max)max=a;
if(b>max)max=b;

Console.Write("max=");
Console.WriteLine(max);
}