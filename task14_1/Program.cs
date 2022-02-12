// 14.2 Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите любое число: ");
string? s1 = Console.ReadLine();

// преобразуем её в число и обратно в строку
if (int.TryParse(s1, out int sInt))
{
    string s2 = Convert.ToString(sInt);
    if (s2.Length >= 3) Console.WriteLine($"Третья цифра числа: {s2[2]}");
    else Console.WriteLine("Это не трёх-значное число");
}

else Console.WriteLine("Вы ввели не число");


