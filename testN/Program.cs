    double weight, height;
repidWeight:
try
{
    Console.WriteLine("Введите свой вес в килограммах:");
    weight = Convert.ToDouble(Console.ReadLine());
}
catch
{
    Console.WriteLine("Введите корректное число");
    goto repidWeight;
}
repidHeight:
try
{
    Console.WriteLine("Введите свой рост в сантиметрах:");
    height = Convert.ToDouble(Console.ReadLine());
}

catch
{
    Console.WriteLine("Введите корректное число");
    goto repidHeight;
}


    height *= 0.01; 
    BodyMassIndex(weight, height);
    Console.ReadLine();

    void BodyMassIndex(double weight, double height)
{
    double bmi = weight / Math.Pow(height, 2);
    bmi = Math.Truncate(bmi);

    if (bmi < 18)
    {
        Console.WriteLine("Индекс массы тела: {0} - Ниже нормального", bmi);
    }
    else if (18 < bmi && bmi < 25)
    {
        Console.WriteLine("Индекс массы тела: {0} - Нормальный", bmi);
    }
    else
    {
        Console.WriteLine("Индекс массы тела: {0} - Выше нормального", bmi);
    }
}
    
