// See https://aka.ms/new-console-template for more information
// int a = 16;
// Console.WriteLine(a);

// Console.WriteLine("Input number ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Quad of " + b + " is " + b *b);

// Задание 1
// Написать программу, которая на вход принимает два целых числа
// и проверяет, является ли первое число квадратом второго.
//  а = 25, b = 5 => да
//  a = 2, b = 10 => нет
//  a = 9, b = -3 => да
//  a = -3, b = 9 => нет

// using System.Threading.Tasks.Dataflow;

// Console.WriteLine("Input  first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b * b)
// {
//     Console.WriteLine($"да {a} квадрат {b}");
// }
// else
// {
//     Console.WriteLine($"нет {a} не является квадратом {b}");
// }

// Задача 2
// Написать программу,которая на вход принимает целое число N,
//  а на выходе показывает все целые числа в промежутке от -N  до N
//  Примеры
//  4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
//  2 => -2, -1, 0, 1, 2

// Console.WriteLine("Input N ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;
// while(start <= n)
// {
//     Console.Write(start + " ");
//     start++; // start = start + 1
// }

// Задача 3. Работа в сессионных залах
// Напимать программу, которая принимает на вход трехзначное число,
// а на выходе показывает сумму первой и последней цифры этого числа.

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 && num < 1000)
{
    int ed = num % 10;
    int sot = num / 100;
    Console.WriteLine("sum = "+ (ed + sot));
}
else
{
    Console.WriteLine("You input not three-digit number");
}