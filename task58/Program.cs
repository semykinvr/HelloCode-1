// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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
    System.Console.WriteLine("Это наш массив: ");
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

// функция перевёртывания строк и столбцов в двумерном массиве
int[,] FlipArray(int[,] array)
{
    int M = array.GetLength(0);
    int N = array.GetLength(1);
    int[,] array2 = new int[M, N];
    if (M == N)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++) array2[i, j] = array[j, i];
    }
    else System.Console.WriteLine("массив не квадратный");

    return array2;
}

int m = InputNumber("Введите M: ");
int n = InputNumber("Введите N: ");
int[,] massiv = FillArray(m, n);
PrintArray(massiv);
int[,] massiv2 = FlipArray(massiv);
PrintArray(massiv2);
