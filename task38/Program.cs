// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// функция заполнения массива из n-элементов рандомными числами
int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = randomNumber.Next(1, 10);
    return array;
}

int[] massiv = FillArray(10); // получили/заполнили массив
Console.WriteLine("Это наш массив:");
for (int i = 0; i < massiv.Length; i++) Console.Write(massiv[i] + " ");

int summaN = 0;
for (int i = 0; i < massiv.Length; i = i + 2) summaN = summaN + massiv[i];

Console.WriteLine("\nСумма чисел на нечётных местах: " + summaN);
