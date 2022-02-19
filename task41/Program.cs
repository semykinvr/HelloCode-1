// 41. Выяснить являются ли три числа сторонами треугольника 
// каждая сторона треугольника меньше суммы двух других сторон

// функция получения рандомного числа
int GetRandomNumber()
{
    int randomNumber1 = new Random().Next(1, 10);
    return randomNumber1;
}

// функция проверки сторона А меньше В+С ?
bool SumTwoNumber(int a, int b, int c)
{
    return a < (b + c);
}

int storonaA = GetRandomNumber();
int storonaB = GetRandomNumber();
int storonaC = GetRandomNumber();
System.Console.WriteLine($"{storonaA}, {storonaB}, {storonaC}");
if (SumTwoNumber(storonaA, storonaB, storonaC) && SumTwoNumber(storonaB, storonaA, storonaC) && SumTwoNumber(storonaC, storonaB, storonaA)) 
System.Console.WriteLine("числа стороны треугольника");
else
System.Console.WriteLine("числа НЕ стороны треугольника");
