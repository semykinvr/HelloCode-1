// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// получаем рандомное число
int GetRandomNumber()
{
    int randomNumber = new Random().Next(10, 99);
    return randomNumber;
}

int number = GetRandomNumber();
Console.WriteLine($"Сгенерировано: {number} ");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit == secondDigit) Console.WriteLine("Обе цифры в числе равны");
else
{
    if (firstDigit > secondDigit) Console.WriteLine($"Максимальная цифра в числе {firstDigit} ");
    else Console.WriteLine($"Максимальная цифра в числе {secondDigit} ");
}
