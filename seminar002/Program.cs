// Задача48. Задайте двумерный массив размера m на n, каждый элемент массива находится по формуле: Amn = m+n.
//Выведите полученый массив на экран.

Console.WriteLine("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите колличество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] array = GetArray(rows, columns);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}