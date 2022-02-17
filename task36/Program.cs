// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// функция заполнения массива из n-элементов рандомными числами
int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = randomNumber.Next(100, 1000);
    return array;
}


int[] massiv = FillArray(20); // получили/заполнили массив
Console.WriteLine("Это наш массив:");
for (int i = 0; i < massiv.Length; i++) Console.Write(massiv[i] + " ");

int countChet = 0;
int countNeChet = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] % 2 == 0) countChet++;
    if (massiv[i] % 2 != 0) countNeChet++;
}

Console.WriteLine($"\nЧётных чисел {countChet} шт, ");
Console.WriteLine($"Нечётных чисел {countNeChet} шт.");
