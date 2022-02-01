// Выяснить является ли число чётным

int num = 0;
bool isNotInt = true;
while (isNotInt)
{
    Console.Write("Введите целое число: ");
    string input = Console.ReadLine();
                // преобразуем строку input в число. и передаём его в num      
    isNotInt = !int.TryParse(input, out num);
}
Console.Write($"Число {num} ");

if (num % 2 == 0) 
{ Console.WriteLine("ЧЁТНОЕ"); } 
else
{ Console.WriteLine("неЧЁТНОЕ"); };
