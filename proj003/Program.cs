int a;

Console.WriteLine("enter a number 'a'");
int.TryParse(Console.ReadLine(), out a);

if (a%2==0)
{
    Console.Write("YES!");
}
else
{
    Console.Write("NO!");
}
