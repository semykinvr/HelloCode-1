﻿// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
string input = Console.ReadLine();

// int numDay = 0;
// try
// {
int numDay = int.Parse(input);
// }
// catch
// {}

string[] names = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
string result = "";
if (numDay < 1 || numDay > 7)
{
   result = "Нет такого дня недели!";
}
else
{
   result = names[numDay - 1];
}
Console.Write("Этот номер дня недели называется: "); Console.WriteLine(result);