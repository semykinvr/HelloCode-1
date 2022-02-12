// 24. Найти кубы чисел от 1 до N

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}

int n = InputNumber("Введите число: ");
Console.WriteLine("Вы ввели N = " + n);
Console.WriteLine("Tаблицa кубов чисел от 1 до N: ");

double[] massivKubov = new double[n];
for (int i = 1; i <= n; i++)
{
    //заполняем массив кубами чисел
    massivKubov[i - 1] = Math.Pow(i, 3);
    //выводим значения массива на экран
    Console.WriteLine($"{i} x {i} x {i} = {massivKubov[i - 1]} ");
}
