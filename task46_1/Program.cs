// 46. Написать программу масштабирования фигуры
// ```
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ```

// !!! попытался сделать по своему на основе лекции  

using System.Linq;

string text = "(1,2) (3,4) (5,6) (7,8)";
Console.WriteLine("Исходная строка: " + text);

text = text.Replace("(", "").Replace(")", "");
Console.WriteLine("Убрали скобки из строки: " + text);

string[] data1 = text.Split(" ");
//.ToArray(); 
Console.WriteLine("Разбили строку (разделитель пробел) и сделали из строки одномерный массив из 4-х элементов: ");
for (int i = 0; i < data1.Length; i++) Console.WriteLine(data1[i]);

var data2 = data1.Select(item => item.Split(","))
.ToArray();
Console.WriteLine("Разбили одномерный массив (разделитель запятая) и сделали массив массивов: ");
for (int i = 0; i < data2.Length; i++)
{
    for (int j = 0; j < data2[i].Length; j++) Console.WriteLine(data2[i][j]);
    System.Console.WriteLine();
}

int k = 2; // к - коэф масштабирования фигуры

int[,] data3 = new int[4, 2];
Console.WriteLine("Из строкового массива сделали числовой: ");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 2; j++)
    {
        data3[i, j] = k * int.Parse(data2[i][j]);
        Console.WriteLine(data3[i, j]);
    }
    System.Console.WriteLine();
}

