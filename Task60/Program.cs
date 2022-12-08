// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int firstDimension = 2;
int secondDimension = 2;
int thirdDimension = 2;

int[,,] numbers = new int[firstDimension, secondDimension, thirdDimension];

FillArray3DDifferentRandomNumbers(numbers);

Write3DArray(numbers);


void FillArray3DDifferentRandomNumbers(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                bool noRepeats = false;
                while (!noRepeats)
                {
                    array[i, j, k] = new Random().Next(10, 100);
                    if (CheckRepeatInArray(array, i, j, k))
                    {
                        noRepeats = false;
                    }
                    else
                    {
                        noRepeats = true;
                    }
                }
            }
        }
    }
}

void Write3DArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

bool CheckRepeatInArray(int[,,] array, int curentIndex1, int curentIndex2, int curentIndex3)
{
    bool haveRepeat = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (curentIndex1 == i && curentIndex2 == j && curentIndex3 == k)
                {
                    haveRepeat = false;
                }
                else if (array[curentIndex1, curentIndex2, curentIndex3] == array[i, j, k])
                {
                    haveRepeat = true;
                    return haveRepeat;
                }
            }
        }
    }
    return haveRepeat;
}
