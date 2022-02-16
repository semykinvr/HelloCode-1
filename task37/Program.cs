// 37. В одномерном массиве из 123 чисел СЛОЖИТЬ ЧИСЛА из отрезка [10,99]

// функция заполнения массива из n-элементов рандомными числами
int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = randomNumber.Next(1, 10);
    return array;
}

int summa = 0;
int[] massiv = FillArray(123); // получили массив
Console.WriteLine("Это наш массив:");
for (int i = 10; i < 100; i++)
{
    Console.Write(" " + massiv[i]);
    summa = summa + massiv[i];
}
System.Console.WriteLine();
Console.WriteLine($"сумма чисел в отрезке [10,99]: {summa}");
