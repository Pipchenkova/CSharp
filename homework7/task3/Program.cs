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
    //создаем одномерный массив  заполняем его суммами столбцов
int[] Final(int[,] array,int amountcolums)
{
    int[] sum = new int[amountcolums];
    for (int i = 0; i < array.GetLength(1); i++)
    {
       int result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }

        sum[i]=result;
    
}
return sum;
}
// печать массива
void Print(int[] Array)
{
    Console.WriteLine("[" + string.Join("; ", Array) + "]");
}
//находим среднеарифметическое
    double[] FinalResult(int[]array,int amountcolums, int amountstrings)
{
double[]avgcolum = new double[amountcolums];
for (int i=0;i<amountcolums;i++)
 
{
    avgcolum[i]= (array[i]*1.0)/ amountstrings;
}
return avgcolum;
}
// печатаем итоговый массив
void PrintFinal(double[] Array)
{
    Console.WriteLine("[" + string.Join("; ", Array) + "]");
}



int amountstrings = GetValue(4, 6);
int amountcolums = GetValue(3, 5);
int[,] array = CreateArray(amountstrings, amountcolums);
Fill(array);
PrintArray(array);
Console.WriteLine("******");
int[]sum = Final(array,amountcolums);
Print(sum);
Console.WriteLine("******");
double[] avgcolum = FinalResult(sum,amountcolums,amountstrings);
PrintFinal(avgcolum);


      
