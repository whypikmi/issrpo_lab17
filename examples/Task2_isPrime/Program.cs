bool isPrime(double a)
{
    if (a <=1)
    {
        return false;
    }
    for(double i = 2; i<a;i++)
    {
        if (a%i == 0)
        return false;
    }
    return true;
}
Console.WriteLine("Нахождение простого числа");
Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
if (isPrime(number))
{
    Console.WriteLine("Число простое");
}
else
{
    Console.WriteLine("Число не простое");
}
