// Здать массив.Написать программу которая определяет,
// присутствует ли заданное число в мвссиве. Программа
// должна выдать ответ: Да/нет.
// Примеры
// [1 3 4 19 3], 8 => нет
// [ -4 3 4 1], 3 => да

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // создали массив
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
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

// System.Console.WriteLine("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);

// //  решение самой задачи
// bool SearhNum(int[] array, int num)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SearhNum(myArray, num));

// Задайте массив из 10 эементов, заполните числами из промежутка [-10;10]
// Замените отрицательные на положительные, а положительные на отрицательные
//  [1 -5 6] => [-1 5 -6]

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // создали массив
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
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

// System.Console.WriteLine("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);

// // Решение
// int[] ChangArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }
// myArray = ChangArray(myArray);
// PrintArray(myArray);

// Задача 3. Создать рандомный массиви из него
// создать другой массив, где первый элемент умножается на последний
// второй на предпоследний и тд

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // создали массив
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
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

// System.Console.WriteLine("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);

// // решение
// int[] CompositionArray(int[] array)
// {
//     int[] ResultArray = new int[array.Length / 2];
//     for ( int i = 0; i < ResultArray.Length; i++)
//     {
//         ResultArray[i] = array[i] * array[array.Length - i - 1];
//     }
//     return ResultArray;
// }
// myArray = CompositionArray(myArray);
// PrintArray(myArray);