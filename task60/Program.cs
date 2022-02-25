// 60. Составить частотный словарь элементов двумерного массива

int[] array = new int[] { 1, 2, 3, 3, 2, 1, 8, 9, 3 };

// функция типа словарь (ключ-значение!) - функция создаёт новый словарь где подсчитан каждый ключ
// например: Dictionary<int, string> people = new Dictionary<int, string>();
Dictionary<int, int> Slovar()
{
    Dictionary<int, int> dic = new Dictionary<int, int>(); // создаём словарь dic (ключ, значение) 
    for (int i = 0; i < array.Length; i++)
        if (dic.ContainsKey(array[i])) //если ключ есть в словаре
            dic[array[i]] = dic[array[i]] + 1; // то значение ключа увеличить на единицу
        else dic.Add(array[i], 1); // если ключа нет в словаре, то создать ключ и присвоить начальное значение 1
    return dic;
}

void PrintSlovar(Dictionary<int, int> dicc)
{
    foreach (var item in dicc) System.Console.WriteLine($"{item.Key} встречается {item.Value} раз");
}
// {item.Key} - возвращает ключ 
// {item.Value} - возвращает значение 

PrintSlovar(Slovar());