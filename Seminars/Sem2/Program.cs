//  методы - функуии
// int Pow (int n) // в данном случае функция возврвщвет значение 
// {
//     return n * n;
// }

// void Pow2(int n)
// {
//     System.Console.WriteLine($"QUAD OF {n} -> {n * n}");
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Pow2(a);

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Pow(a);
// System.Console.WriteLine(result); // для функции которая возвращает значения


// Напишите программу, которая принимает на вход
// трехзначное число и удаляет вторую цифру этого числа
// Примеры
// а = 256=> 26
// a = 891 = 81

// bool IsThreeGigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// int DeleteSecondDigit(int num)
// {
//     if(IsThreeGigit(num))
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return sot * 10 + ed;
//     }
//     else
//     {
//         System.Console.WriteLine(" You input not three-digit number");
//         return 0;
//     }
// }

// void DeleteSecondDigit(int num)
// {
//     if(IsThreeGigit(num))
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         System.Console.WriteLine(ed + sot *10);
//     }
//     else
//     {
//         System.Console.WriteLine(" You input not three-digit number");
        
//     }
// }
// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// DeleteSecondDigit(a); // System.Console.WriteLine(DeleteSecondDigit(a)); 


//  Напишите программу, которая принимает на вход трехзначное число
//  и возводит вторую цифру этого числа в степень, равнуютретьей цифре.
// Примеры
//  487 => 8^7 = 2 067 152
//  254 => 5^4 = 625
// 617 => 1


// bool IsThreeGigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void SecondToThirdPower(int num)
// {
//     if (IsThreeGigit(num))
//     {
//         int ed = num % 10;
//         int dec = num /10 % 10;
//         System.Console.WriteLine(Math.Pow(dec, ed));
//     }
//     else
//     {
//         System.Console.WriteLine(" You input not three-digit number");
//     }  
// }
// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// SecondToThirdPower(a);

// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли первое число кратным второму. Если первое число
// некратно второму, то программа выводит остаток от деления
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет 1

System.Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
bool multiplicity (int a, int b)
{
    if ( a % b == 0)
    {
        return true;
    }
    else
    return false;
}
void Result (int a, int d)
{
    if (multiplicity (a,b))
    {
        System.Console.WriteLine("да");
    }
    else
    {
        System.Console.WriteLine($"нет {a % b}");
    }
}
Result(a, b);