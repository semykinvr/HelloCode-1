// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// функция заполнения массива из n-элементов рандомными числами (дробными)
double[] FillArray(int n)
{
    double[] array = new double[n];
    Random randomNumber = new Random();
        for (int i = 0; i < array.Length; i++) array[i] = Convert.ToDouble(randomNumber.Next(-99, 100)/10.0);
        //for (int i = 0; i < array.Length; i++) array[i] = randomNumber.NextDouble();
    return array;
}

double[] massiv = FillArray(10); // получили/заполнили массив
Console.WriteLine("Это наш массив:");
for (int i = 0; i < massiv.Length; i++) Console.Write(massiv[i] + "  ");

double max = massiv[0];
double min = massiv[0];
for (int i = 0; i < massiv.Length; i++) 
{
if (massiv[i] > max) max = massiv[i];
if (massiv[i] < min) min = massiv[i];
}

Console.WriteLine("\nРазница между максимальным и минимальным элементом: " + (max - min));

