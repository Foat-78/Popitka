﻿// Метод 4. что то принимает и что то возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, " zv|");
Console.WriteLine(res);

