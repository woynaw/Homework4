bool Check(int arg)
{
    if (arg < 0)
    {
        Console.WriteLine("Введено ненатуральное число");
        return false;
    }
    else return true;
}

int Power(int arg1, int arg2)
{
    int result = 1;
    for (int i = 0 ; i < arg2; i++)
    {
        result *= arg1;
    }
    return result;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени");
int step = Convert.ToInt32(Console.ReadLine());
if (Check(num))
{
    Console.WriteLine($"{num}, {step} -> {Power(num, step)}");
}