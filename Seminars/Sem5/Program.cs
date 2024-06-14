// ввод двумерного массива
// int[,] CreateRandomMatrix(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             matrix[i, j] = random.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }
// PrintMatrix(CreateRandomMatrix(4, 4, 0, 9));

// System.Console.WriteLine("Input rows: ");
//  int rows = Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine("Input colums: ");
//  int colums = Convert.ToInt32(Console.ReadLine()); 
//  Console.WriteLine("input min: ");
//  int min = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("input max: ");
//  int max = Convert.ToInt32(Console.ReadLine());

// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса четные и замениете эти элементы на их квадраты

int[,] CreateRandomMatrix(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

 System.Console.WriteLine("Input rows: ");
 int rows = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Input colums: ");
 int colums = Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine("input min: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("input max: ");
 int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateRandomMatrix(rows, colums, min, max);

// int [,] EvenNumsToQuad(int[,] matrix)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//         }
//     }
//     return matrix;
// }

// PrintMatrix(matrix);
// matrix = EvenNumsToQuad(matrix);
// PrintMatrix(matrix);


// задача 2
// Задайте двумерныймассив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0, 0), (1, 1) и тд)

// int SumOfMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                 sum += matrix[i, j];
//             }
//         }
//     }
//     return sum;
// }

// PrintMatrix(matrix);
// System.Console.WriteLine(SumOfMainDiagonal(matrix));


// Задача 3
// Задайте двумерный массив. Сформировать новый одномерный массив,
// состщящий из средних арифметических элементов каждой
//  строки исходного массива

double[] SrAr(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)// перебирает каждый элемент в строке
        {
            sum += matrix[i, j];
        }
        result[i] = (double)sum / matrix.GetLength(1);
    }
    return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("");
}
PrintMatrix(matrix);
PrintArray(SrAr(matrix));