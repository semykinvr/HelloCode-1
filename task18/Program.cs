// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.WriteLine("Проверяем истинность утверждения !(X || Y) = !X & !Y");

bool x = true;
bool y = true;
if ((!(x || y)) == (!x & !y)) Console.WriteLine("утверждение истинно"); else Console.WriteLine("утверждение ложно");

x = false;
y = true;
if ((!(x || y)) == (!x & !y)) Console.WriteLine("утверждение истинно"); else Console.WriteLine("утверждение ложно");

x = true;
y = false;
if ((!(x || y)) == (!x & !y)) Console.WriteLine("утверждение истинно"); else Console.WriteLine("утверждение ложно");

x = false;
y = false;
if ((!(x || y)) == (!x & !y)) Console.WriteLine("утверждение истинно"); else Console.WriteLine("утверждение ложно");

