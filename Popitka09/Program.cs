// Работа с текстом.
// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буквы "к" заменить на большие  буквы "К", а большие 
// "С" заменить маленькими "с".
 
 string text = "Приветствую вас на лекции по введению в программирование. Мы продолжаем разбираться " 
            + "с методами. На предыдущем занятии мы узнали, для чего они нужны. Узнали, что они, как " 
            + "правило, решают подзадачи. Сегодня мы углубимся в тему и выделим 4 основных группы " 
            + "методов, а также будем использовать их на практике. И познакомимся с новыми языковыми " 
            + "конструкциями, в частности, циклом. Приступим.";

// Пояснение:
// string s = "qwerty"
//             012
// s[3] = r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'к', 'К');
Console.WriteLine(newText);
newText = Replase(text, 'С', 'с');
Console.WriteLine(newText);

