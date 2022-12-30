Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] spirallyMatrix = SpirallyFillMatrix(m, n);
PrintMatrix(spirallyMatrix);

int[,] SpirallyFillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    int minValue = 1;
    int maxValue = m * n;
    int i = 0;
    int j = 0;
    int point = 0;
    while (minValue <= maxValue)
    {
        matrix[i, j] = minValue;
        if (i == point && j < n - 1 - point) j++;
        else if (j == n - 1 - point && i < m - 1 - point) i++;
        else if (i == m - 1 - point && j > point) j--;
        else if (j == point && i > point) i--;
        if (i == point && j == point)
        {
            i++; j++; point++;  
        }
        minValue++;
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write("0" + matrix[i, j] + " ");
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
