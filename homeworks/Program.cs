// Задача 1

// System.Console.WriteLine("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// void multiplicity (int a)
// {
//     if ( a % 7 == 0 && a % 23 == 0)
//     {
//         System.Console.WriteLine("да кратно");;
//     }
//     else
//     {
//         System.Console.WriteLine("нет не кратно");
//     }
// }
// multiplicity(a);


// Задача 2
// System.Console.WriteLine("Input coordinate x: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input coordinate y: ");
// int b = Convert.ToInt32(Console.ReadLine());

// bool CheckingTheCondition (int x, int y)
// {
//     if (x != 0 && y != 0 )
//     {
//         return true;
//     }
//     return false;
// }
// void CoordinateQuarter (int x, int y)
// {
//     if (CheckingTheCondition(x, y))
//     {
//         if (x > 0 && y > 0)
//         {
//             System.Console.WriteLine(" I координатная четверть");
//         }
//         if (x > 0 && y < 0)
//         {
//             System.Console.WriteLine(" II координатная четверть");
//         }
//         if (x < 0 && y < 0)
//         {
//             System.Console.WriteLine(" III координатная четверть");
//         }
//         if (x < 0 && y > 0)
//         {
//             System.Console.WriteLine(" IV координатная четверть");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("Некоректные данные");
//     }
// }
// CoordinateQuarter(a,b);



// Задача 3
// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// bool IsTwoGigit(int num)
// {
//     if (num > 9 && num < 100)
//     {
//         return true;
//     }
//     return false;
// }
// void Result(int num)
// {
//     if (IsTwoGigit(num))
//     {
//         int ed = num % 10;
//         int dec = num / 10;
//         if (ed > dec)
//         {
//             System.Console.WriteLine($"{ed}");
//         }
//         else
//         {
//             System.Console.WriteLine($"{dec}");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("the number is not included in the specified segment");
//     }
// }
// Result(a);



// Задача 4 Написать программу, которая на входпринимает натуральное число
// N, а на выходе показывает его цифры через запятую. 
System.Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());