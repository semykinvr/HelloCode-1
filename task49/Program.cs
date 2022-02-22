// 49. Показать двумерный массив размером (m × n) заполненный вещественными числами

System.Console.Write("Введите M: ");
var m = int.Parse(Console.ReadLine());
System.Console.Write("Введите N: ");
var n = int.Parse(Console.ReadLine());

// функция заполнения двумерного массива (M x N) рандомными вещественными числами
double[,] FillArray(int M, int N)
{
    System.Console.Write("Заполнили двумерный массив рандомными вещественными числами: \n");
    double[,] array = new double[M, N];
    Random randomNumber = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //array[i, j] = randomNumber.NextDouble();
            //array[i, j] = Convert.ToDouble(randomNumber.Next(-99, 100)/10.0);
            array[i, j] = Math.Round(randomNumber.NextDouble()*10, 2); // округление до второго знака
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine("");
    }
return array;    
}

FillArray(m, n);


