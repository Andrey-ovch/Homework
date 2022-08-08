//  Задача 29: Напишите метод, который задаёт массив 
//  из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Print(int[] array)
{
    int length = array.Length;
    Console.Write($"[ ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"]");
    Console.WriteLine();

}

int CountSym(string s, char c)
{
    int length = s.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c) count++;
    }
    return count;
}

int IndexSep(string s, char c)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == c) return i;
    }
    return -1;
}

string SubStr(string s, int pos)
{
    string NewString = string.Empty;
    for (int i = pos; i < s.Length; i++)
    {
        NewString += $"{s[i]}";
    }
    return NewString;
}

string SubStrLeng(string s, int pos, int size)
{
    string NewString = string.Empty;
    for (int i = pos; i < pos + size; i++)
    {
        NewString += $"{s[i]}";
    }
    return NewString;
}

int[] NewString(string s)
{
    int[] array = new int[CountSym(s, ',') + 1];
    s += ',';
    int index = 0;
    string newS= string.Empty;
    while (s.Length != 0)
    {
        int PosSep = IndexSep(s, ',');
        Console.WriteLine($"pos: {PosSep}");
        string newStr1 = SubStrLeng(s, 0, PosSep);
        Console.WriteLine($"newStr1: {newStr1}");
        string newStr = SubStr(s, PosSep + 1);
        newS = newS + newStr1;
        Console.WriteLine($"newStr: {newS} ");
        s = newStr;
        array[index] = Convert.ToInt32(newStr1);
        index++;
    }
    return array;
}

// Console.WriteLine(
// CountSym("143,243,3343,4354,565,3243,7657,23", ','));
// Console.WriteLine(
// IndexSep("143,243,3343,4354,565,3243,7657,23", ','));

// string news = "143,243,3343,4354,565,3243,7657,23";
// Console.WriteLine(news);
// Console.WriteLine(SubStr(news, 5));
// Console.WriteLine(SubStrLeng(news, 4, 9));

Console.Write($"Введите числа через запятую: ");
string f = Console.ReadLine()!;
int[] arr = NewString(f);
Print(arr);
