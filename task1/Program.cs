// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);

if (num1 == num2 * num2)
{
    Console.Write(num1);
    Console.Write(" является квадратом ");
    Console.WriteLine(num2);
}
else
{
    Console.Write(num1);
    Console.Write(" не является квадратом ");
    Console.WriteLine(num2);
}