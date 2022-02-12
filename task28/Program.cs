// 28. Подсчитать сумму цифр в числе

// получаем рандомное число
int GetRandomNumber()
{
    int randomNumber = new Random().Next(100, 10000);
    return randomNumber;
}

int n = GetRandomNumber();
Console.WriteLine($"Сгенерировано: {n} ");

int summa = 0;
while (n != 0)
{
    summa = summa + n % 10;
    n = n / 10;
}

Console.WriteLine("Сумма цифр в числе: " + summa);
