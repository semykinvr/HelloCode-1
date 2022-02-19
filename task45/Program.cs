// 45. Показать числа Фибоначчи 
// - сделано через рекурсию, как на лекции.
// (см. 45.1 - так сделано на семинаре)

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
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
for (int i = 1; i <= N; i++) Console.WriteLine($"f({i}) = {Fibonacci(i)}");

