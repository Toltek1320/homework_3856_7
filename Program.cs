// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int numMaxValue = SetNumber("Max Value");
int numMinValue = SetNumber("Min Value");
var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
double[,] GetMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = Convert.ToDouble(new Random().Next(min*10, (max + 1)*10)) / 10;
        }
        
    }
    return matrix;
}
void Print(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[10, 10];
GetMatrix(matrix);
Print(matrix);
Console.WriteLine();
void GetMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            matrix[i, l] = new Random().Next(1, 10);
        }
    }
}
void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}
if (rows > matrix.GetLength(0) || columns > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {rows} строки и {columns} столбца равно {matrix[rows - 1, columns - 1]}");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
int numMaxValue = SetNumber("Max Value");
int numMinValue = SetNumber("Min Value");
var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
Console.WriteLine();
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max + 1);
        }

    }
    return matrix;
}
void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}
for (int l = 0; l < matrix.GetLength(1); l++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, l]);
    }
    avarage = avarage / numRows;
    Console.Write(avarage + "; ");
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];

int temp = 1;
int i = 0;
int l = 0;

while (temp <= n * n)
{
    matrix[i, l] = temp;
    if (i <= l + 1 && i + l < n - 1)
        ++l;
    else if (i < l && i + l >= n - 1)
        ++i;
    else if (i >= l && i + l > n - 1)
        --l;
    else
        --i;
    ++temp;
}

Print(matrix);

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
