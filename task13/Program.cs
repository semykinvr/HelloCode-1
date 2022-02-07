// Выяснить, кратно ли число заданному, если нет, вывести остаток.

// функция получения рандомного числа
int GetRandomNumber()
{
    int randomNumber = new Random().Next(20, 100);
    return randomNumber;
}

// функция получения остатка
int Ostatok(int n1, int n2)
{
    int result = 0;
    if (n1 >= n2) result = n1 % n2;
    if (n1 <= n2) result = n2 % n1;
    return result;
}


int number1 = GetRandomNumber();
Console.WriteLine($"Сгенерировано число1: {number1} ");
int number2 = GetRandomNumber();
Console.WriteLine($"Сгенерировано число2: {number2} ");

int ost = Ostatok(number1, number2);
if (ost == 0) Console.WriteLine("Одно число кратно другому");
else Console.WriteLine($"Числа не кратны друг другу, остаток: {ost}");
