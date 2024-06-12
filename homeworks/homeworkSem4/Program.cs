// Задача 1
// Написать программу, которая бесконечно запрашивает целые числа с консоли
// Программа завершается при вводе символа 'q' или при вводе числа, сума цифр которого четная.
// Задача 2
// Задать массив заполненный случайными трехзначными числами.
// Написать программу,которая покажет кол-во четных чисел в массиве.

int[] RandomArray(int size)
{
    int[] array = new int [size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = random.Next(100, 999 +1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] +" ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(size);
PrintArray(myArray);

int CounterOfEvenNumbers(int[] array)
{
    int counter = 0;
    for( int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

// int counter = CounterOfEvenNumbers(myArray);
// System.Console.WriteLine(counter);
System.Console.WriteLine(CounterOfEvenNumbers(myArray));// другой способ вывода данных


// Задача 3
// Написать программу, которая перевернет одномерный массив
// (первый элемент станет последним, второй предпоследним и т.д.)
