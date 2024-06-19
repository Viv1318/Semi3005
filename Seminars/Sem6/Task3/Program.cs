static void Main()
{
    System.Console.WriteLine("Введите ланиские буквы нижнего регистра:");
    string str = Console.ReadLine();
    str = str.ToLower();// переводим в нижний регистр
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
    int count = 0;
    for(int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
                break;
            }
        }
    }
    System.Console.WriteLine($"Колличество гласных букв: {count}");
}
Main();