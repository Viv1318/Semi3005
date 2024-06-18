// обратная задача из строки сделать массив

char[] StringToChars(string str)
{
    char[] result = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        result[i] = str[i];
    }
    return result;
}
void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("'" + array[i] + "' ");
    }
    System.Console.Write("");
}
PrintArray(StringToChars("asdfghh"));