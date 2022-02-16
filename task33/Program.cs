// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

int summaPol = 0;
int summaOtr = 0;
int[] massiv = new int[12];
//
for (int i=0; i<12; i++)
{
    massiv[i] = new Random().Next(-9, 10); //заполнение массива рандомными числами от -9 до 9
    System.Console.Write($"{massiv[i]} "); 
    if (massiv[i]>0) summaPol = summaPol + massiv[i]; // суммируем положительные
    if (massiv[i]<0) summaOtr = summaOtr + massiv[i]; // суммируем отрицательные
}
System.Console.WriteLine($"\nСумма положительных: {summaPol}"); 
System.Console.WriteLine($"Сумма отрицательных: {summaOtr}");