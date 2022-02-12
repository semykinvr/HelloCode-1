// 30. Показать кубы чисел, заканчивающихся на чЁтную цифру

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}

int N = InputNumber("Введите число: ");
Console.WriteLine("Вы ввели N = " + N);
Console.WriteLine("Кубы чисел от 1 до N, которые чётные: ");

double[] massivKubov = new double[N];
for (int i = 1; i <= N; i++)
{
    //заполняем массив кубами чисел
    massivKubov[i - 1] = Math.Pow(i, 3);
    //выводим значения массива на экран
    if ((massivKubov[i - 1] % 2) == 0) Console.WriteLine($"{i} x {i} x {i} = {massivKubov[i - 1]} ");
}
