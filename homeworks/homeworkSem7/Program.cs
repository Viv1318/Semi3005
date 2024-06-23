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

System.Console.WriteLine("Input non-negative number m: ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input non-negative number n: ");
int n = Convert.ToInt32(System.Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return 0;
}

System.Console.WriteLine(Akkerman(m, n));