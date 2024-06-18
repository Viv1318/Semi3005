//  Задайте массив символов (тип char []). Создайте строку из 
// символов этого массива.
// Указание: конструктор строки вида string(char [])  не использовать.
// Пример: ['a', 'b', 'c', 'd'] => "abcd"

string CharToString(char[] chars)
{
    string result = string.Empty;//обьявили пустую строку
    for (int i = 0; i < chars.Length; i++)
    {
        result += chars[i];
    }
    return result;
}

char[] chars = { 'a', 'b', 'c', 'd' }; // создали массив символов
System.Console.WriteLine(CharToString(chars));