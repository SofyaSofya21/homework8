// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows1 = ReadInt("Введите количество строк для создания первой матрицы: ");
int columns1 = ReadInt("Введите количество столбцов для создания первой матрицы: ");

int rows2 = ReadInt("Введите количество строк для создания второй матрицы: ");
int columns2 = ReadInt("Введите количество столбцов для создания второй матрицы: ");

if (columns1 == rows2)
{
    int[,] numbers1 = new int[rows1, columns1];
    int[,] numbers2 = new int[rows2, columns2];
    FillMatrixRandomNumbers(numbers1);
    FillMatrixRandomNumbers(numbers2);

    int[,] multiplication = new int[rows1, columns2];
    multiplication = MultiplyMatrix(numbers1, numbers2);

    WriteMatrix(numbers1);
    WriteMatrix(numbers2);
    Console.WriteLine("Результат умножения матриц: ");
    WriteMatrix(multiplication);
}
else
    Console.WriteLine("Матрицы не согласованы, невозможно выполнить умножение");



int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int l = 0; l < matrix1.GetLength(0); l++)
    {
        for (int n = 0; n < matrix2.GetLength(1); n++)
        {
            for (int m = 0; m < matrix1.GetLength(1); m++)
            {
                result[l, n] += matrix1[l, m]* matrix2[m, n];
            }
        }
    }
    return result;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


