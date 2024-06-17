int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};
int[] SumRows(int[,] numbers)
{
    int[] result = new int[numbers.GetLength(0)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[i, j];
        }
        result[i] = sum;
    }
    return result;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("");
}
PrintArray(SumRows(numbers));
System.Console.WriteLine();
int MinIndex(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}
int minIndex = MinIndex(SumRows(numbers));
System.Console.Write(minIndex);
System.Console.WriteLine();
void PrintResult(int[,] numbers)
{
    int i = MinIndex(SumRows(numbers));
    System.Console.WriteLine(i);
}

PrintResult(numbers);