// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
//1. метод генерации случайного числа:
int GetValue(int min, int max)
{
    return new Random().Next(min, max);
}
//2. создаем массив:
int[,] CreateArray(int m, int n)
{
    return new int[m, n];
}
//3. заполняем массив:
void Fill(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = GetValue(0, 9);
        }
    }
}

// Печать массива
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { Console.Write($"{matr[i, j]} "); }
        Console.WriteLine();
    }
}
// Решение
void Final(int[,] array, int indexstring, int indexcolum)
{
    if (array.GetLength(0) <= indexstring || array.GetLength(1) <= indexcolum)
    {
        Console.WriteLine("Такого числа нет");

    }
    else
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == indexstring && j == indexcolum)
                {
                    Console.WriteLine(array[i, j]);
                }

            }
        }
    }


}
int m = GetValue(4, 5);
int n = GetValue(5, 8);
Console.WriteLine($"{m}*{n}");
int[,] array = CreateArray(m, n);
Fill(array);
PrintArray(array);
int SearchString = GetValue(2, 4);
int SearchColum = GetValue(4, 9);
Console.Write(SearchString);
Console.WriteLine(SearchColum);
Final(array, SearchString, SearchColum);


