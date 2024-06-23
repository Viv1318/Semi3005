// Вывести числа от 1 до n включительно.

// void OutpotN(int n)
// {
//     if (n > 0)
//     {
//         OutpotN(n - 1);
//         System.Console.Write(n  + " ");
//     }
// }
// OutpotN(7);

// написать программу,которая принимет на вход число,а возвращает
// сумму всех цифр этого числа.

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());

// int SumDigits(int num)
// {
    
//     if (num < 10)
//     {
//         return num;
//     }
//     else
//     {
//         return num % 10 + SumDigits(num / 10);
//     }
    
// }

// System.Console.WriteLine("сумма чисел введенного числа равна" + " " + SumDigits(num));

// написать программу,которая принимает на вход два числа A и B, и возводит число A в степень B.

 int Pow(int a, int b)
 {
    if (a == 1)
     {
         return 1;
     }
     if (b == 1)
     {
         return a;
     }
     if (b == 0)
     {
         return 1;
     }
     else
     {
         return a * Pow(a, b - 1);
     }
 }
 System.Console.WriteLine(Pow(5,0));