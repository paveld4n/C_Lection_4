// вывести двумерную матрицу

// String.Empty - инициализация пустой строки
// table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]
// table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]

int[,] matrix = new int[3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}