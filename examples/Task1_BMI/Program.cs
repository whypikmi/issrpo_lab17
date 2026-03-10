Console.WriteLine("Программа для расчёта ИМТ");
Console.Write("Введите ваш вес: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите ваш рост: ");
double height = Convert.ToDouble(Console.ReadLine());
double IMT = Math.Round(weight / (height * height),1);
Console.WriteLine($"Ваш ИМТ: {IMT}");
string category;
string recomendation;
if (IMT < 18.5)
{
    category = "Недостаточный вес";
    recomendation = "Набрать вес";
}
else if (IMT >= 18.5 && IMT <= 24.9)
{
    category = "Нормальный вес";
    recomendation = "Оставаться в такой же форме";
}
else if (IMT >= 25 && IMT <= 29.9)
{
    category = "Избыточный вес";
    recomendation = "Обратить внимание на вес и начать заниматься спортом";
}
else
{
    category = "Ожирение";
    recomendation = "Обратиться к врачу и обязательно идти заниматься спортом";
}
Console.WriteLine($"Категория: {category}");
Console.WriteLine($"Рекомендация: {recomendation}");