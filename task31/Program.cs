// 31. Задать массив из N элементов и вывести их на экран 

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}

// функция заполнения массива из n-элементов рандомными числами
int[] ArrayInit(int n)
{
    int[] array = new int[n];
    Random randomNumber = new Random();
    for (int i = 0; i < n; i++) array[i] = randomNumber.Next(1, 10);
    return array;
}

// функция вывода массива на печать
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}


int N = InputNumber("Введите число: ");
int[] massiv = ArrayInit(N);
PrintArray(massiv);
