// Напишите программу, которая приниамет на вход число
// и выдает количество цифр в числе.
// 456 => 3
// 78 => 2
// 89126 => 5

int DigitsCounter(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num /=10;
        counter++;
    }
    return counter;
}
System.Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = DigitsCounter(num);
System.Console.WriteLine(counter);