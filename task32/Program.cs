// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// функция заполнения массива из n-элементов рандомными числами
byte[] ArrayInit(int n)
{
    byte[] array = new byte[n];
    Random randomNumber = new Random();
    for (int i = 0; i < n; i++) array[i] = Convert.ToByte(randomNumber.Next(0, 2));
    return array;
}

// функция вывода массива на печать
void PrintArray(byte[] array)
{
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}

int n = 8;
byte[] massiv = ArrayInit(n);
PrintArray(massiv);
