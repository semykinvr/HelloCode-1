// 12. Удалить вторую цифру трёхзначного числа


// функция запроса числа у пользователя
int GetIntegerFromConsole(int min, int max)
{
    string? input; 
    int result =0; 
    bool isError = true;
    while (isError)
    {
        System.Console.Write("Введите трёхзначное число: ");
        // input = Convert.ToInt32(Console.ReadLine());
        input = Console.ReadLine();
        if (int.TryParse(input, out result)) isError = (result < min) ||  (result > max);
    }
    return result;
}

// получение последней цифры это остаток от деления на 10
int GetLastDigit (int gld) { return (gld % 10); }



int vvedeno = GetIntegerFromConsole(100, 999);
Console.WriteLine("Вы ввели число: " + vvedeno);
int d3 = GetLastDigit (vvedeno);
int d2 = GetLastDigit (vvedeno/10);
int d1 = GetLastDigit (vvedeno/10/10);

Console.WriteLine("Первая цифра: " + d1);
Console.WriteLine("Вторая цифра: " + d2);
Console.WriteLine("Третья цифра: " + d3);

Console.Write("УБРАЛИ ВТОРУЮ ЦИФРУ: " + (d1*10+ d3));
