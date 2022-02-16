// 35. Определить, присутствует ли в заданном массиве, некоторое число 

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    //return Convert.ToInt32(input);
    return number;
}

// функция заполнения массива из n-элементов рандомными числами
static int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = randomNumber.Next(1, 10);
    return array;
}


int a = InputNumber("Введите число: ");
Console.WriteLine("Вы ввели " + a);
int[] massiv = new int[20];
massiv = FillArray(20); // получили массив
bool search = false;
for (int i = 0; i < massiv.Length; i++)
{    
    Console.Write(" " + massiv[i]);
    if (massiv[i] == a) search = true; 
}
System.Console.WriteLine();
if (search) Console.WriteLine("в массиве есть число " + a);
else Console.WriteLine("в массиве нет числа " + a);
