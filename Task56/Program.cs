// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
//элементов: 1 строка

int rows = ReadInt("Введите количество строк для создания массива: ");
int columns = ReadInt("Введите количество столбцов для создания массива: ");
int minRawIndex = 0;
int rawSum = 0;
int minRawSum = 0;

int[,] numbers = new int[rows, columns];

FillMatrixRandomNumbers(numbers);

WriteMatrix(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    
    if (i == 0)
    {
        minRawSum = SumRaw(numbers, i);
        minRawIndex = i;
    }
    else
    {
        rawSum = SumRaw(numbers, i);
        if (rawSum < minRawSum)
        {
            minRawSum = SumRaw(numbers, i);
            minRawIndex = i;
        }
    }
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRawIndex+1} строка.");



int SumRaw(int[,] array, int raw)
{
    int rawSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        rawSum += array[raw, i];
    }
    return rawSum;
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

