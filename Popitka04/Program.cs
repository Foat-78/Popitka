// Метод 2. чего-то принимает и ничего не возвращает
void Method2(string msg)
{
    Console.Write(msg);
}
Method2("Текст для Фоата .....");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        ++i;
    }
}
Method21("Фоат !!!!!!", 4);