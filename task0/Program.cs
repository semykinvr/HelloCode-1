// Вывести квадрат числа

Console.Write("Введите число: ");
// вводим число с консоли и присваиваем его строковой переменной
string numberStr = Console.ReadLine(); 

// преобразовываем строковую переменную numberStr в челочисленную переменную nnumber с помощью функции int.Parse()
int number = int.Parse(numberStr);

// выводим на экран
// Console.Write("Число "); Console.Write(number); Console.Write(" в квадрате равно: "); Console.WriteLine(number*number);
Console.WriteLine($"Число {number} в квадрате равно: {number*number}");
