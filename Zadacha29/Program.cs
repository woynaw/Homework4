int[] RandomArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random random = new Random();
    for (int i = 0; i < len - 1; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length-1]}");
    System.Console.Write("]");
}



Console.WriteLine("Введите размер массива");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите левую границу");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(len, min, max);
PrintArray(array);
