// 34. Написать программу замену элементов массива на противоположные по знаку

// функция заполнения массива из n-элементов рандомными числами
int[] FillArray(int n)
{
    int[] array = new int[n];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = randomNumber.Next(-9, 10);
    return array;
}

// функция инверсии чисел в массиве
int[] InversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = (-1)*array[i];
    return array;
}

int[] massiv = FillArray(20); // получили/заполнили массив
Console.WriteLine("Это наш массив:");
for (int i = 0; i < massiv.Length; i++) Console.Write(" " + massiv[i]);

massiv = InversArray(massiv); // получили инверсный массив
Console.WriteLine("\nЭто инверсный массив:");
for (int i = 0; i < massiv.Length; i++) Console.Write(" " + massiv[i]);
