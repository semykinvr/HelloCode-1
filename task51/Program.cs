// 51. Задать двумерный массив следующим правилом: Aₘₙ = m + n

System.Console.Write("Введите M: ");
var m = int.Parse(Console.ReadLine());
System.Console.Write("Введите N: ");
var n = int.Parse(Console.ReadLine());

// функция заполнения двумерного массива по правилу Aₘₙ = m + n
int[,] FillArray(int M, int N)
{
    System.Console.Write("Заполняем двумерный массив по правилу \n");
    int[,] array = new int[M, N];
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j; //правилj Aₘₙ = m + n
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine("");
    }
return array;    
}

FillArray(m, n);

