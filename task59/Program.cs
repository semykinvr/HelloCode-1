// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

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
System.Console.WriteLine("Это наш массив: ");
PrintArray(massiv);


int summa = 0;
for (int j = 0; j < massiv.GetLength(1); j++) summa = summa + massiv[0, j];

int min = summa;
int imin = 0;
summa = 0;
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        summa = summa + massiv[i, j];
    }
    if (summa < min)
    {
        min = summa;
        imin = i;
        summa = 0;
    }
    else summa = 0;
}

System.Console.WriteLine($"Строка {imin + 1} c наименьшей суммой элементов: ");
for (int j = 0; j < massiv.GetLength(1); j++) System.Console.Write(massiv[imin, j] + "  ");
