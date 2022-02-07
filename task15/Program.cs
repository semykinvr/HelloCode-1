// 15. Дано число. Проверить кратно ли оно 7 и 23

// получаем рандомное число
int GetRandomNumber()
{
    int randomNumber = new Random().Next(7, 7777);
    return randomNumber;
}

int number = GetRandomNumber();
Console.WriteLine($"Сгенерировано: {number} ");

int k7 = number % 7;
int k23 = number % 23;

if (k7 == 0) Console.WriteLine($"Число: {number} кратно 7");
if (k23 == 0) Console.WriteLine($"Число: {number} кратно 23");
if (k23 !=0 && k7 !=0) Console.WriteLine($"Число {number} не кратно 7 и 23");
if (k23 == 0 && k7 == 0) Console.WriteLine($"Число {number} кратно 7 и 23");
