// есть две даты. вывести на экран количество полных лет, дней. Кто старше и на сколько.


DateTime data1 = new DateTime(1973, 04, 23);
DateTime data2 = new DateTime(1976, 11, 01);

Console.WriteLine("Vitaliy " + data1.ToShortDateString());
Console.WriteLine("    Ann " + data2.ToShortDateString());
Console.WriteLine("======================");

DateTime today = DateTime.Now;
Console.WriteLine("Сегодня " + today);
Console.WriteLine("======================");

int old1 = today.Year - data1.Year;
int old2 = today.Year - data2.Year;
Console.WriteLine($"Vitaliy`s {old1} лет");
Console.WriteLine($"    Ann`s {old2} лет");
Console.WriteLine("======================");

if (old1 > old2) Console.WriteLine($"Vitaliy старше на {old1 - old2} лет");
else             Console.WriteLine($"    Ann старше на {old2 - old1} лет");

