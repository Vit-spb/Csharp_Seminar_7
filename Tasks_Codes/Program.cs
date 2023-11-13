// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3 (кол-во строк), n = 4 (кол-во столбцов).
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// minValue - мин. число для рандома, maxValue - макс. число для рандома  

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
    {
        // i, j, k, m
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
        }
        Console.WriteLine();
    }
}
int[,] array2D = GetMatrix(rows, columns, 0, 10);
PrintMatrix(array2D);

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)

Amn = m + n (элемент матрицы А равен = ном. стр + ном.стл)
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
    {
        // i, j, k, m
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
        {
            matrix[i, j] = i + j; // Mij = i + j
            // Amn = m + n
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
        }
        Console.WriteLine();
    }
}
int[,] array2D = GetMatrix(rows, columns);
PrintMatrix(array2D);

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// // Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// // minValue - мин. число для рандома, maxValue - макс. число для рандома  

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
    {
        // i, j, k, m
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
        }
        Console.WriteLine();
    }
}

int[,] ChangeMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i += 2) // стр
    {
        for (int j = 0; j < matr.GetLength(1); j += 2) // столбцы
        {
            // if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
            // {
            matr[i, j] *= matr[i, j];
            // matr[i, j] = matr[i, j] * matr[i, j]
            // }
        }
    }
    return matr;
}


int[,] array2D = GetMatrix(rows, columns, 0, 10);
PrintMatrix(array2D); // Тут матрицу сохранили для дал. испол.
Console.WriteLine("Результат: ");
PrintMatrix(ChangeMatrix(array2D));

double[,] GetDoubleMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2); // 0 - 1000 
        }
    }
    return matrix;
}
void PrintDoubleMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
        }
        Console.WriteLine();
    }
}
double[,] array2D = GetDoubleMatrix(rows, columns);
PrintDoubleMatrix(array2D); // Тут матрицу сохранили для дал. испол.