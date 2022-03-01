// 73. Написать программу показывающую первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

// функция ввода числа с клавиатуры
int InputNumber(string message)
{
    System.Console.Write(message);
    string? input = Console.ReadLine();
    int number;
    bool checkInput = int.TryParse(input, out number);
    while (!checkInput)
    {
        System.Console.Write(message);
        input = Console.ReadLine();
        checkInput = int.TryParse(input, out number);
    }
    return number;
}


int n1 = InputNumber("Введите N1: ");
int n2 = InputNumber("Введите N2: ");
int n = InputNumber("Введите количество чисел: ");
int n3;

System.Console.Write(n1 + " ");
System.Console.Write(n2 + " ");
for (int i = 3; i <= n; i++)
{
    n3 = n1 + n2;
    n1 = n2;
    n2 = n3;
System.Console.Write(n3 + " ");
}
