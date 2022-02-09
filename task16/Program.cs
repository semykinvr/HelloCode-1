// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

// функция получения числа с консоли
int GetWeeklyNumber()
{
    int i = 0;
    string? input = String.Empty;
    while (i < 1 || i > 7)
    {
        Console.WriteLine("Введите номер дня недели от 1 до 7: ");
        //string? input = Console.ReadLine();
        input = Console.ReadLine();
        //i = Convert.ToInt32(input);
        int.TryParse(input, out i);
        //Console.WriteLine("i= " + i);
    }
    return i;
}



int n = GetWeeklyNumber();
Console.WriteLine("Введён номер: " + n);
if (n == 6 || n == 7)
    Console.WriteLine("Ура, это выходной день!");
else
    Console.WriteLine("Это рабочий день.");
