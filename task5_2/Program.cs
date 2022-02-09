//  Написать программу вычисления значения функции y = f(a) 

// СУММА ЧИСЕЛ В МАССИВЕ

int[] massiv = new int[4];
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(1, 10);
    Console.Write($"Число: {massiv[i]}, ");
}

Console.WriteLine("");

int s = SUMMA_MASSIVA(massiv, massiv.Length);
Console.Write("Cумма чисел: " + s);

// Это функция SUMMA_MASSIVA
static int SUMMA_MASSIVA(int[] massiv1, int length1)
{
    int s1 = 0;
    for (int i = 0; i < length1; i++) s1 = s1 + massiv1[i];

    return Convert.ToInt32(s1);
}

