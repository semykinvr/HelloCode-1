// 27. Определить количество цифр в числе

// получаем рандомное число
int GetRandomNumber()
{
    int randomNumber = new Random().Next(100, 1000000000);
    return randomNumber;
}

int N = GetRandomNumber();
Console.WriteLine($"Сгенерировано: {N} ");

int count = 0;
while (N != 0) 
{
N = N / 10;
count++;
}

Console.WriteLine("Количество цифр в числе: " + count);
