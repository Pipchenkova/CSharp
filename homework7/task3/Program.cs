// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//1. метод генерации случайного числа:
int GetValue(int min, int max)
{
    return new Random().Next(min, max);
}
//2. создаем массив:
int [,] CreateArray(int m, int n)
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
            array[i, j] = GetValue(0, 4);
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
void Final(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }

        Console.Write($" Сумма столбца = {sum} ");
        int result = sum/array.GetLength(0);
        Console.WriteLine($"Среднеарифметическое столбца = {result}");
        Console.WriteLine();
    
}
}



int amountstrings = GetValue(4, 6);
int amountcolums = GetValue(3, 5);
int[,] array = CreateArray(amountstrings, amountcolums);
Fill(array);
PrintArray(array);
Final(array);
      
