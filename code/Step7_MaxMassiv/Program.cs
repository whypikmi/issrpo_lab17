Console.WriteLine("Поиск максимального элемента");
Console.Write("Введите количество элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numbers];
Console.Write($"Введите {numbers} элементов массива: ");
for (int i = 0; i < numbers; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
int max = array[0];
for (int i = 1; i < numbers; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Максимальный элемент массива: {max}");