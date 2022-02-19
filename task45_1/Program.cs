// 45. Показать числа Фибоначчи 
// - сделано через цикл .
// (см. 45. - так сделано на лекции, через рекурсию)

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double GetFibonacci(int n)
{
    double n1 = 0;
    double n2 = 1;
    double temp;
    for (int i = 0; i < n; i++)
    {
        temp = n1;
        n1 = n2;
        n2 = temp + n2;
    }
    Console.WriteLine($"f({n}) = {n1}");
    return n1;
}

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    //return Convert.ToInt32(input);
    return number;
}

int N = InputNumber("Введите число: ");
Console.WriteLine("Вы ввели: " + N);
Console.WriteLine("Числа Фибоначчи: ");
for (int i = 0; i <= N; i++) GetFibonacci(i);


