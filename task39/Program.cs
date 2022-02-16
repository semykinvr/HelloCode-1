// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    //return Convert.ToInt32(input);
    return number;
}

// функция заполнения массива из n-элементов рандомными числами
int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = randomNumber.Next(1, 10);
    return array;
}


int a = InputNumber("Введите число: ");
Console.WriteLine("Вы ввели " + a);
int[] massiv = FillArray(a); // получили массив

Console.WriteLine("Это наш массив:");
for (int i = 0; i < massiv.Length; i++) Console.Write(" " + massiv[i]);

Console.WriteLine("\nПроизведения 'крайних' пар в массиве: ");
for (int i = 0; i < massiv.Length / 2; i++) Console.Write(" " + massiv[i] * massiv[massiv.Length - 1 - i]);
