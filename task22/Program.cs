// 22. Найти расстояние между точками в пространстве 2D/3D

// функция ввода числа с консоли
double InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToDouble(input);
}

// функция вычисляет длинну диагонали куба по формуле
double DiagonalKuba(double x, double y, double z)
{
    double diagonal = Math.Sqrt(x * x + y * y + z * z);
    return diagonal;
}

double x1 = InputNumber("Введите Х1: ");
double y1 = InputNumber("Введите Y1: ");
double z1 = InputNumber("Введите Z1: ");
Console.WriteLine($"Координата первой точки: X1={x1}; Y1={y1}; Z1={z1}");
double x2 = InputNumber("Введите Х2: ");
double y2 = InputNumber("Введите Y2: ");
double z2 = InputNumber("Введите Z2: ");
Console.WriteLine($"Координата второй точки: X2={x2}; Y2={y2}; Z2={z2}");

double X = Math.Abs(x2-x1); 
double Y = Math.Abs(y2-y1); 
double Z = Math.Abs(z2-z1); 

Console.WriteLine("Длинна между двумя точками: " + DiagonalKuba(X,Y,Z));
