// Задача 1
// Напишите программу, которая приниамет на вход число
// и выдает количество цифр в числе.
// 456 => 3
// 78 => 2
// 89126 => 5

// int DigitsCounter(int num)
// {
//     int counter = 0;
//     while (num > 0)
//     {
//         num /=10;
//         counter++;
//     }
//     return counter;
// }
// System.Console.WriteLine("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// // int counter = DigitsCounter(num);
// // System.Console.WriteLine(counter);
// System.Console.WriteLine(DigitsCounter(num));// другой способвывода решения


// Задача 2
// Задайте массив из N случайных чисел (N вводится с клавиатуры)
// Найти ко-во чисел, которые оканчиваюся на 1 и кратны 7

int[] InputArray(int size)
{
    int[] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
       System.Console.WriteLine($"Input {i+1} number: "); // ввод элементов массива с компа
       arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int ArrayCounter(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 10 == 1 && arr[i] % 7 == 0)
        {
            count++;
        }
    }
    return count;
}
System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = InputArray(size);// ссылка на участок памяти компьютера
System.Console.WriteLine(ArrayCounter(arr));