// Найти максимальное из трёх чисел


// описали массив
double[] numbers = new double[3];

// заполняем массив
for (int i = 1; i <= numbers.Length; i++) {
   Console.Write($"Введите число №{i}: ");
   numbers[i-1] = Convert.ToDouble(Console.ReadLine());
}

// выводим массив
for (int i = 1; i <= numbers.Length; i++) 
   Console.WriteLine($"Число №{i}: "+ numbers[i-1]);
    

double max = numbers[0];
double min = numbers[0];

// вычисляем max и min

for (int i = 0; i < numbers.Length; i++)
{   if (numbers[i] > max) max = numbers[i];
    if (numbers[i] < min) min = numbers[i];
    }

Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
