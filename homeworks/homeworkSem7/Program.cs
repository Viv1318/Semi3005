// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// System.Console.WriteLine("Input number m: ");
// int m = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input number n: ");
// int n = Convert.ToInt32(System.Console.ReadLine());
// void OutpotN(int m, int n)
// {
//     if (m == n)
//     {
//         System.Console.Write(m);
//     }
//     if (m < n)
//     {
//         System.Console.Write(m + " ");
//        OutpotN(m + 1, n);
//     }
//     if (m > n)
//     {
//         System.Console.Write(m + " ");
//        OutpotN(m - 1, n);
//     }
    
// }
// OutpotN(m, n);

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


// System.Console.WriteLine("Input non-negative number m: ");
// int m = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input non-negative number n: ");
// int n = Convert.ToInt32(System.Console.ReadLine());
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (m > 0 && n == 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     if (m > 0 && n > 0)
//     {
//         return Akkerman(m - 1, Akkerman(m, n - 1));
//     }
//     return 0;
// }

// System.Console.WriteLine(Akkerman(m, n));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int [size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = random.Next(min, max + 1);
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
System.Console.WriteLine("input min number: ");
int min = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("input max number: ");
int max = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);  

void ArrayReversal (int[] array, int i )
{ 
    if (i >= 0)
    {
        Console.Write(array[i] + " ");
        ArrayReversal(array, i - 1);
        
    }
}
ArrayReversal(myArray, myArray.Length - 1);    