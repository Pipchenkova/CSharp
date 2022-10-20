// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// 1.получаем случайное число - размер массива
// 2. заполняем случайными числами
//3. округляем числа до двух знаков
// 4. печатаем массив
// 5. находим разницу между макс и мин


// int size = new Random().Next(5,10);
// double[] array = new double[size];
// Random rand = new Random();
// for( int i=0; i<size; i++)
// {
//     array[i] = rand.Next(-1, 10) + rand.NextDouble();

// }
// for (int i=0; i<size;i++)
// {
//     array[i]=Math.Round(array[i],2);
// }
// Console.WriteLine(string.Join(";",array));
// double MaxNumber = array.Max();
// double MinNumber = array.Min();
// double difference = MaxNumber - MinNumber;
// double resultDif = Math.Round(difference,2);
// Console.WriteLine(resultDif);

int GetValue(int min, int max)
{
    return new Random().Next(min, max);
}
double[] CreateArray(int size)
{
    return new double[size];
}
void Fill(double[] array)
{
    int size = array.Length;
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-1, 10) + rand.NextDouble();

    }
}
void Round(double[] array)
{
    int size = array.Length;
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]=Math.Round(array[i],2);

    }
}
void Print(double[] Array)
{
    Console.WriteLine("[" + string.Join("; ", Array) + "]");
}

double Final(double[] array)
{
    double MaxNumber = array.Max();
    double MinNumber = array.Min();
    double difference = MaxNumber - MinNumber;
    double resultDif = Math.Round(difference, 2);
    return resultDif;
}
int size = GetValue(4, 8);
double[] array = CreateArray(size);
Fill(array);
Round(array);
Print(array);
double result = Final(array);
Console.WriteLine(result);


