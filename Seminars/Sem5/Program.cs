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

int [,] EvenNumsToQuad(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
    return matrix;
}
PrintMatrix(matrix);
matrix = EvenNumsToQuad(matrix);
PrintMatrix(matrix);