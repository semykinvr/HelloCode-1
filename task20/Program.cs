// 20. Задать номер четверти, показать диапазоны для возможных координат


// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}

int n = 0;
while (n < 1 || n > 4) n = InputNumber("Введите № четверти на координатной плоскости X Y : ");
Console.WriteLine("Вы ввели номер " + n);

switch (n)
{ 
    case 1: Console.WriteLine("в 1 четверти координаты точек: X > 0 и Y > 0"); break;
    case 2: Console.WriteLine("в 1 четверти координаты точек: X < 0 и Y > 0"); break;
    case 3: Console.WriteLine("в 1 четверти координаты точек: X < 0 и Y < 0"); break;
    case 4: Console.WriteLine("в 1 четверти координаты точек: X > 0 и Y < 0"); break;
}



//Ploskost(x1, y1);


