// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// функция типа кортеж, ищем мин. элемент в двумерном массиве, возвращает индексы этого элемента
(int, int) FindMinInArray(int[,] array)
{
    int iStr = 0;
    int jCol = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                iStr = i;
                jCol = j;
            }
    return (iStr, jCol);
}

// функция заполнения двумерного массива рандомными целыми числами
int[,] FillArray(int M, int N)
{
    int[,] array = new int[M, N];
    Random randomNumber = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = randomNumber.Next(1, 100);
    return array;
}

// функция печати двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

// функция ввода числа с клавиатуры
int InputNumber(string message)
{
    System.Console.Write(message);
    string? input = Console.ReadLine();
    int number;
    bool checkInput = int.TryParse(input, out number);
    while (!checkInput)
    {
        System.Console.Write(message);
        input = Console.ReadLine();
        checkInput = int.TryParse(input, out number);
    }
    return number;
}


int m = InputNumber("Введите M: ");
int n = InputNumber("Введите N: ");
int[,] massiv = FillArray(m, n);
System.Console.WriteLine("Это наш изначальный массив: ");
PrintArray(massiv);
// Console.WriteLine("Индексы минимального элемента: " + FindMinInArray(massiv));
(int minStr, int minCol) = FindMinInArray(massiv);
Console.WriteLine($"Индексы минимального элемента в массиве:  i = {minStr},  j = {minCol}");

// Формируем новый массив - удаляем столбец
int[,] massiv2 = new int[m, n - 1];
int i = 0;
int j = 0;
int t = 0;
for (i = 0; i < m; i++)
{
    for (j = t = 0; j < n; j++, t++)
    {
        if (j < minCol) massiv2[i, t] = massiv[i, j];
        else if (j == minCol) j++;
        massiv2[i, t] = massiv[i, j];
    }
}
System.Console.WriteLine("удалили столбец: " + minCol);
PrintArray(massiv2);

// Формируем новый массив - удаляем строку
int[,] massiv3 = new int[m - 1, n - 1];
i = 0;
j = 0;
t = 0;
for (j = 0; j < n - 1; j++)
{
    for (i = t = 0; i < m; i++, t++)
    {
        if (i < minStr) massiv3[t, j] = massiv2[i, j];
        else if (i == minStr) i++;
        massiv3[t, j] = massiv2[i, j];
    }
}
System.Console.WriteLine("удалили строку: " + minStr);
PrintArray(massiv3);


