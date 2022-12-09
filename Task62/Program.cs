// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = ReadInt("Введите количество строк массива: ");
int columns = ReadInt("Введите количество колонок массива: ");

int[,] numbers = new int[rows, columns];

numbers = FillMatrixSpiral(numbers, 0, 0);

WriteSpiralMatrix(numbers);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrixSpiral(int[,] array, int row, int col)
{
    int count = 1;
    int cellQuantity = array.GetLength(0) * array.GetLength(1);
    array[row, col] = count;
    count++;
    while (count < cellQuantity + 1)
    {
        while (col + 1 < array.GetLength(1) && array[row, col + 1] == 0)
        {
            col++;
            array[row, col] = count;
            count++;
        }
        while (row + 1 < array.GetLength(0) && array[row + 1, col] == 0)
        {
            row++;
            array[row, col] = count;
            count++;
        }
        while (col > 0 && array[row, col - 1] == 0)
        {
            col--;
            array[row, col] = count;
            count++;
        }
        while (row > 0 && array[row - 1, col] == 0)
        {
            row--;
            array[row, col] = count;
            count++;
        }
    }
    return array;
}

void WriteSpiralMatrix(int[,] array)
{
    int cellQuantity = array.GetLength(0) * array.GetLength(1);
    string additionalZero = string.Empty;
    if (cellQuantity > 9 && cellQuantity < 100)
        additionalZero = "0";
    else if (cellQuantity > 99 && cellQuantity < 1000)
        additionalZero = "00";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write(additionalZero + array[i, j] + " ");
            else if (array[i, j] < 100 && cellQuantity > 99 && cellQuantity < 1000)
            {
                additionalZero = "0";
                Console.Write(additionalZero + array[i, j] + " ");
            }
            else
                Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

