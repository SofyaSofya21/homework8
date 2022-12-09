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


DrawTriangle(triangle);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void DrawTriangle(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.SetCursorPosition(Console.WindowWidth/2-array.GetLength(1)/2,i+1);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0)
                Console.Write(" ");
            else
                Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
