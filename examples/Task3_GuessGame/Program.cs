Random random = new Random();
while (true)
{
    int number = random.Next(1, 101);
    int pop = 0;
    Console.WriteLine("Компьютер загадал число от 1 до 100, угадайте его.");
    while (true)
    {
        Console.Write("Введите число: ");
        if (!int.TryParse(Console.ReadLine(), out int input))
        {
            Console.WriteLine("Введите целое число");
            continue;
        }
        if (input < 1 || input > 100)
        {
            Console.WriteLine("Число должно быть от 1 до 100");
            continue;
        }
        pop++;
        if (input == number)
        {
            Console.WriteLine($"Молодец, ты угадал. Число: {number}");
            Console.WriteLine($"Количество попыток: {pop}");
            break;
        }
        if (input < number)
        {
            Console.WriteLine($"Загаданное число больше.");
        }
        else
        {
            Console.WriteLine($"Загаданное число меньше.");
        }
    }
    Console.Write("Будете ещё играть? (y/n): ");
    char answer = Convert.ToChar(Console.ReadLine());
    if (answer == 'n')
    {
        Console.WriteLine("Удачи. Спасибо за игру.");
        break;
    }
}