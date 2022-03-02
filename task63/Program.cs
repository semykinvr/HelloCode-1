// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

// !сделал, но как "заполнить не повторяющимися числами" не знаю...


// функция заполнения трёхмерного массива рандомными целыми числами
int[,,] FillArray(int M, int N, int K)
{
    int[,,] array = new int[M, N, K];
    Random randomNumber = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++) array[i, j, k] = randomNumber.Next(10, 100);
    return array;
}

// функция печати трёхмерного массива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"({i},{j},{k}) = {array[i, j, k]}    ");
            }
            Console.WriteLine();
        }
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
int kk = InputNumber("Введите K: ");
int[,,] massiv = FillArray(m, n, kk);

System.Console.WriteLine("Это наш трёхмерный массив: ");
PrintArray(massiv);

