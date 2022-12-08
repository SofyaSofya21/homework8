// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

int rows = ReadInt("Введите количество строк для создания массива: ");
int columns = ReadInt("Введите количество столбцов для создания массива: ");

int[,] numbers = new int[rows, columns];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int temp = 0;
    int count = numbers.GetLength(1); // счетчик, сколько элементов надо проверять
    while (count > 1)
    {
        int minColumn = 0;
        int min = numbers[i, minColumn];
        for (int j = 0; j < count; j++)
        {
            if (numbers[i, j] < min)
            {
                min = numbers[i, j];
                minColumn = j;
            }
        }
        temp = numbers[i, count - 1];
        numbers[i, count - 1] = min;
        numbers[i, minColumn] = temp;
        count--;
    }
}

WriteMatrix(numbers);


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
