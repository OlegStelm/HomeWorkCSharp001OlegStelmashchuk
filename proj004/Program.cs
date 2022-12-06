int a;

Console.WriteLine("enter a number: ");
int.TryParse(Console.ReadLine(), out a);

for (int index=2;index<=a; index+=2)
{
    Console.Write($"{index} ");
}
