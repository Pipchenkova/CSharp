// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// 1.получаем случайное число - размер массива
// 2. заполняем случайными числами
// 3. печатаем массив
// 4. находим разницу между макс и мин


int size = new Random().Next(5,10);
double[] array = new double[size];
Random rand = new Random();
for( int i=0; i<size; i++)
{
    array[i] = rand.Next(-1, 10) + rand.NextDouble();

}
for (int i=0; i<size;i++)
{
    array[i]=Math.Round(array[i],2);
}
Console.WriteLine(string.Join(";",array));
double MaxNumber = array.Max();
double MinNumber = array.Min();
double difference = MaxNumber - MinNumber;
double resultDif = Math.Round(difference,2);
Console.WriteLine(resultDif);

