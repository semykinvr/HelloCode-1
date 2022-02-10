// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}

// определяем плоскость
void Ploskost(int x, int y)
{
    if (x>0 && y>0) Console.WriteLine("точка находится в 1 четверти"); 
    if (x<0 && y>0) Console.WriteLine("точка находится в 2 четверти"); 
    if (x<0 && y<0) Console.WriteLine("точка находится в 3 четверти"); 
    if (x>0 && y<0) Console.WriteLine("точка находится в 4 четверти"); 
}

int x1 = InputNumber("Введите Х: ");
int y1 = InputNumber("Введите Y: ");
Ploskost(x1,y1);


