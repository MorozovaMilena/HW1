Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Число " + a + " максимальное");
    Console.Write("Число " + b + " минимальное");
}
else if (a == b)
{
    Console.WriteLine("Число " + a + " равно числу " + b);
}
else
{
    Console.WriteLine("Число " + b + " максимальное");
    Console.Write("Число " + a + " минимальное");}
