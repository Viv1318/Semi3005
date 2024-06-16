int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};
int FindElementByPosition(int[,] array, int x, int y)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if (i +1 == x && j + 1 == y)
            {
                array[x, y] = array[i, j];
            }
        }
    }
    return array[x, y];
}


bool ValidatePosition(int[,] array, int x, int y)
{
    
    if (x >= 0 && x < array.GetLength(0) && y >= 0 && y < array.GetLength(1))
    {
        return true;
    }
    return false;
    
}
void PrintResult(int[,] numbers, int x, int y)
{
    if (ValidatePosition(numbers, x, y))
    {
        int result = FindElementByPosition(numbers, 2, 2);
        System.Console.WriteLine(result);
        
    }
    else
    {
        System.Console.WriteLine("Позиция выходит за пределение массива");
        
    }
    
}
PrintResult(numbers, 2, 2);