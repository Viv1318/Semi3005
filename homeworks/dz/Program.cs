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
// System.Console.WriteLine("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
//     System.Console.WriteLine(N);
// }
// else
// {
//     while(N > 0)
//     {
//         int currentDigit = N % 10;
//         N /= 10;
//         if (N > 0)
//         {
//             System.Console.Write(currentDigit + ",");
//         }
//         else
//         {
//             System.Console.WriteLine(currentDigit);
//         }
//     }
// }

// Семинар3

// int[] CreateRandomArray(int numbers, int minRange, int maxRange)
// {
//     int[] array = new int[numbers]; // создали массив
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

// System.Console.WriteLine("Input numbers: ");
// int numbers = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minRange: ");
// int minRange = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maxRange value of array element: ");
// int maxRange = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(numbers, minRange, maxRange);
// PrintArray(myArray);


// int[] myArray = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
// int countEven = 0;
// for( int i = 0; i < myArray.Length; i++)
// {
//         if(myArray[i] % 2 == 0)
//         {
//             countEven++;
//         }
// }    
// System.Console.WriteLine(countEven);

// int countNumb = 0;
// for(int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i] > 10 && myArray[i] < 90)
//     {
//         countNumb++;
//     }
// }
// System.Console.WriteLine(countNumb);


// задача 3
double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
}
System.Console.WriteLine(min);

double max = array[0];
for(int i = 0; i < array.Length;i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
}
System.Console.WriteLine(max);
System.Console.WriteLine(max - min);