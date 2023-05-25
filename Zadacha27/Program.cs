int SumDig(int arg)
{
    int sum = 0;
    while (arg > 0)
    {
        sum += arg % 10;
        arg /= 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {SumDig(num)}");