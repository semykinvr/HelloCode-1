//  Написать программу вычисления значения функции y = f(a) 


// СУММА ДВУХ ЧИСЕЛ

Console.Write("Введите X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());

double s = SUMMA(x1, y1);
Console.Write("Cумма двух чисел (X + Y) равно: "+ s);

// Это функция SUMMA
static double SUMMA(double parametr_x, double parametr_y) {
    return Convert.ToDouble(parametr_x + parametr_y); 
}

