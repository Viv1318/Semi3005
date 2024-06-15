// Задача 1
// Написать программу, которая бесконечно запрашивает целые числа с консоли
// Программа завершается при вводе символа 'q' или при вводе числа, сума цифр которого четная.


while(true)
{
    System.Console.WriteLine("введите целое число или q");
    string a = Console.ReadLine();
    if (a == "q")
    {
        break;
    }
    int number;
    if (int.TryParse(a, out number))//проверка является ли ввод числом
    {
        int sum = 0;
        while(number > 0)
        {
            sum += number % 10;
            number /= 10;
       
        }
        if (sum % 2 == 0 )
        {
            break;
        }
    }
    else
    {
        System.Console.WriteLine("введите целое число или q");
    }   
}

// Задача 2
// Задать массив заполненный случайными трехзначными числами.
// Написать программу,которая покажет кол-во четных чисел в массиве.

// int[] RandomArray(int size)
// {
//     int[] array = new int [size];
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//        array[i] = random.Next(100, 999 +1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] +" ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = RandomArray(size);
// PrintArray(myArray);

// int CounterOfEvenNumbers(int[] array)
// {
//     int counter = 0;
//     for( int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             counter++;
//         }
//     }
//     return counter;
// }

// // int counter = CounterOfEvenNumbers(myArray);
// // System.Console.WriteLine(counter);
// System.Console.WriteLine(CounterOfEvenNumbers(myArray));// другой способ вывода данных


// Задача 3
// Написать программу, которая перевернет одномерный массив
// (первый элемент станет последним, второй предпоследним и т.д.)


// int[] CreateRandomArray(int size, int minRange, int maxRange)
// {
//     int[] array = new int[size]; // создали массив
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(minRange, maxRange + 1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();// если метод будет вызываться 2 раза подрят между массивами делает разрыв
// }

// System.Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minRange: ");
// int minRange = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maxRange value of array element: ");
// int maxRange = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minRange, maxRange);
// PrintArray(myArray); 

// void ArrayReversal(int[] array)
// {
//     for (int i = myArray.Length - 1; i >= 0; i--)
//     {
//         Console.Write(myArray[i] +" ");
//     }
// }
// ArrayReversal(myArray);
