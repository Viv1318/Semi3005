// Вывести числа от 1 до n включительно.

void OutpotN(int n)
{
    if (n > 0)
    {
        OutpotN(n - 1);
        System.Console.Write(n  + " ");
    }
}
OutpotN(7);