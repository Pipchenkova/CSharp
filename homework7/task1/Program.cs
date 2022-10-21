// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

//1. Пишем метод получения случайного числа

int GetValue(int min, int max)
{
    return new Random().Next(min, max);
}
//2. Метод создания массива:
double[,] CreateArray(int m, int n)
{
    return new double[m, n];
}
//3. Заполняем массив:
void Fill(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-1, 10) + rand.NextDouble();
        }
    }

}
//4. Округляем числа
void Round(double[,] array)
{

    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
}
//5. Печатаем массив:
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { Console.Write($"{matr[i, j]} "); }
        Console.WriteLine();
    }
}
int m = GetValue(2,5);
int n = GetValue(3,6);
double[,] array= CreateArray(m,n);
Fill(array);
Round(array);
PrintArray(array);