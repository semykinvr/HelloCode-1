// 61. Найти произведение двух матриц

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
int[,] massiv1 = FillArray(m, n);
int[,] massiv2 = FillArray(m, n);
System.Console.WriteLine("Это наш изначальный двумерный массив (1): ");
PrintArray(massiv1);
System.Console.WriteLine("Это наш изначальный двумерный массив (2): ");
PrintArray(massiv2);

int[,] massiv3 = new int[m, n];
for (int i = 0; i < massiv3.GetLength(0); i++)
    for (int j = 0; j < massiv3.GetLength(1); j++) massiv3[i, j] = massiv1[i, j] * massiv2[i, j];

System.Console.WriteLine("Это перемножение двух массивов (1) * (2): ");
PrintArray(massiv3);
