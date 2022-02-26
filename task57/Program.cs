// 57. Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

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

// функция упорядочивания по убыванию элементов в каждой строке двумерного массива.
int[,] OrderArray(int[,] array)
{
    int count;
    int temp;
    int M = array.GetLength(0);
    int N = array.GetLength(1);
    for (int i = 0; i < M; i++)
    {
        count = 1;
        while (count > 0)
        {
            count = 0;
            for (int j = 0; j < N - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                    count++;
                }
            }
        }
    }
    return array;
}


int m = InputNumber("Введите M: ");
int n = InputNumber("Введите N: ");
int[,] massiv = FillArray(m, n);
System.Console.WriteLine("Это исходный массив: ");
PrintArray(massiv);
int[,] massiv2 = OrderArray(massiv);
System.Console.WriteLine("Это сортированный по строкам массив: ");
PrintArray(massiv2);