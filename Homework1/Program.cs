
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine());

int value = 1;
for(int i=1; i <= b; i++)
{
    value = value * a;
}

Console.WriteLine(value);