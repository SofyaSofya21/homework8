// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде 
// равнобедренного треугольника*

int size = ReadInt("Введите количество строк треугольника Паскаля: ");

int[,] triangle = new int[size, size + (size - 1)];

if (size == 1)
    Console.WriteLine(size);
else
{
    //значения первой строки
    triangle[0, triangle.GetLength(1) / 2] = 1;
    //значения промежуточных строк
    for (int i = 1; i < triangle.GetLength(0); i++)
    {
        for (int j = 1; j < triangle.GetLength(1) - 1; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j + 1];
        }
    }
    //значения последней строки
    triangle[triangle.GetLength(0) - 1, 0] = 1;
    triangle[triangle.GetLength(0) - 1, triangle.GetLength(1) - 1] = 1;
}

DrawTriangleViaRows(triangle);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void DrawTriangleViaRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string[] row = new string[array.GetLength(1)];
        for (int index = 0; index < row.Length; index++)
        {
            row[index] = Convert.ToString(array[i, index]);
            if (row[index] == "0")
                row[index] = " ";
        }
        PrintRow(row, i);
    }
}

void PrintRow(string[] array, int rawNumber)
{
    Console.SetCursorPosition(Console.WindowWidth/2-array.Length/2, 2+rawNumber);
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

// void DrawTriangle(int[,] array)
// {
//     int rows = array.GetLength(1);
//     string additionalZero = string.Empty;
//     if (rows > 5 && rows < 10)
//         additionalZero = " ";
//     else if (rows > 10 && rows < 14)
//         additionalZero = "  ";
//     else if (rows > 14)
//         additionalZero = "   ";

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == 0)
//                 Console.Write(additionalZero);
//             else
//                 Console.Write(array[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


