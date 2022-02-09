// Показать четные числа от 1 до n

int max = 0; 
while (max <= 1)
{
    Console.Write("Введите натуральное число, больше единицы: ");
    string? input = Console.ReadLine();
    int.TryParse(input, out max);
}

int num = 2;
Console.Write($"Это чётные числа от 1 до {max}:  ");
while (num <= max)
{
    Console.Write($"{num},  ");
    num += 2;
}
Console.WriteLine("");
