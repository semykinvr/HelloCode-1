// Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int num1 = int.Parse(input1);

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int num2 = int.Parse(input2);

if (num1 != num2) 
{
Console.Write("большее число: " + Math.Max(num1, num2));    
Console.Write(", меньшее число: " + Math.Min(num1, num2));
}
else {Console.Write($"Оба числа равны: ( {num1} = {num1} )");}


// if (num1 != num2) 
// {
    
// if (num1 > num2)
// {    Console.Write("большее число: " + num1 + " меньшее: " + num2);    }
// else
// {    Console.Write("большее число: " + num2 + " меньшее: " + num1);   }

// }
// else {Console.Write($"Оба числа равны: ( {num1} = {num1} )");}

