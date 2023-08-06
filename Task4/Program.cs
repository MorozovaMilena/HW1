Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = 2;

while (num >= result)
{
    Console.Write(result + " ");
    result = result + 2;
}
