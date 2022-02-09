//  Написать программу вычисления значения функции y = f(a) 


// ПЛОЩАДЬ КРУГА

Console.Write("Введите параметр 'а' :");
float a = Convert.ToSingle(Console.ReadLine());
float y = F(a);
Console.WriteLine("Значение функции y=f(a): "+ y);

// Это функция F
static float F(float parametr_a) {
    return Convert.ToSingle(Math.PI*Math.Pow(parametr_a, 2)); 
}

