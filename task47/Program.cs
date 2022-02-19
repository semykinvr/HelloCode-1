// 47. Написать программу копирования массива

// функция заполнения массива из n-элементов рандомными числами
int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = randomNumber.Next(1, 10);
    return array;
}

// функция копирования массива
int[] CopyArray(int[] array1)
{
    int[] array2 = new int[array1.Length];
    for (int i = 0; i < array2.Length; i++) array2[i] = array1[i];
    return array2;
}

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    //return Convert.ToInt32(input);
    return number;
}

int N = InputNumber("Введите число: ");
Console.WriteLine("Вы ввели " + N);
int[] massiv1 = FillArray(N); // получили массив
int[] massiv2 = CopyArray(massiv1); // сделали копию массива
int[] massiv3 = new int[N];
Array.Copy(massiv1, massiv3, massiv1.Length); // сделали копию массива через встроенную функцию
var massiv4 = massiv1.Select(x=>x).ToArray(); // сделали копию массива через встроенную функцию2

Console.WriteLine("Первый массив: ");
for (int i = 0; i < massiv1.Length; i++) Console.Write(massiv1[i] + " ");
Console.WriteLine("\nКопия массива: ");
for (int i = 0; i < massiv2.Length; i++) Console.Write(massiv2[i] + " ");
Console.WriteLine("\nКопия массива (3): ");
for (int i = 0; i < massiv3.Length; i++) Console.Write(massiv3[i] + " ");
Console.WriteLine("\nКопия массива (4): ");
for (int i = 0; i < massiv4.Length; i++) Console.Write(massiv4[i] + " ");

