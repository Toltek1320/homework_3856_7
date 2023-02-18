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
