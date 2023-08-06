Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int rem = num % 2;
if (rem == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
