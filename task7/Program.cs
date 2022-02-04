// Показать числа от -N до N
 

Console.Write("Введите число: ");
int input = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"Числа от -{input} до {input}: ");
for (int i = (-1)*input; i <= input; i++) Console.WriteLine(i);

