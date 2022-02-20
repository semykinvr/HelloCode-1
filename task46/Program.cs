// 46. Написать программу масштабирования фигуры
// ```
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ```

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
.Replace("(", "")
.Replace(")", "")
;
System.Console.WriteLine(text);

var data = text.Split(" ")
.Select(item => item.Split(","))
.Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
.Select(point => (point.x*2, point.y*2))
.ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    //for (int j = 0; j < data[i].Length; j++) Console.WriteLine(data[i][j]);
    //System.Console.WriteLine();
}
