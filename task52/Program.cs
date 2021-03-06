// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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


int m = InputNumber("Введите M: ");
int n = InputNumber("Введите N: ");
int[,] massiv = FillArray(m, n);
PrintArray(massiv);

for (int i = 0; i < massiv.GetLength(0); i++)
    for (int j = 0; j < massiv.GetLength(1); j++)
        if ((i % 2 == 0) && (j % 2 == 0)) massiv[i, j] = massiv[i, j] * massiv[i, j];

System.Console.WriteLine("Изменённый массив - ");
PrintArray(massiv);
