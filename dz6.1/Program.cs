// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

// 0, 7, 8, -2, -2 ---> 2
// 1, -7, 567, 89, 223 ---> 4

void Print(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
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
    string newS = string.Empty;
    while (s.Length != 0)
    {
        int PosSep = IndexSep(s, ',');
        // Console.WriteLine($"pos: {PosSep}");
        string newStr1 = SubStrLeng(s, 0, PosSep);
        // Console.WriteLine($"newStr1: {newStr1}");
        string newStr = SubStr(s, PosSep + 1);
        newS = newS + newStr1;
        // Console.WriteLine($"newStr: {newS} ");
        s = newStr;
        array[index] = Convert.ToInt32(newStr1);
        index++;
    }
    return array;
}

int CountPlus(int[] array)
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            s++;
        }
    }
    return s;
}


Console.Write($"Введите числа через запятую: ");
string f = Console.ReadLine()!;
int[] arr = NewString(f);
Print(arr);
int c = CountPlus(arr);
Console.WriteLine($"Количество чисел больше 0: {c}");
