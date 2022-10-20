// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях

// 1.получаем случайное число - размер массива
//2. создаем массив
// 3. заполняем случайными числами
// 4. печатаем массив
// 5. берем позиции через один. начиная с i=1, и складываем значения

// int size = new Random().Next(2,10);
// int[] array = new int[size];
// for( int i=0; i<size; i++)
// {
//     array[i] = new Random().Next(-10,10);
// }
// Console.WriteLine(string.Join(",",array));
// int sum = 0;
// for( int i=1; i<size; i=i+2)
// {
//     sum +=array[i];
// }
// Console.WriteLine(sum);

int GetValue(int min, int max)
      {
       return new Random().Next(min, max);
    }
    int[] CreateArray(int value)
     {
     return new int[value];
    }
void Fill(int[] Array)
{
    int size = Array.Length;
    for (int i = 0; i<size; i++)
    {
        Array[i] = GetValue(1, 20);
    }
}
void Print(int[] Array)
{
    Console.WriteLine("[" + string.Join(",", Array) + "]");
}
int Final(int[]array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 1; i< size; i=i+2)
    {

     sum +=array[i];
   }
   return sum;
    }
int size = GetValue(3,7);
int[] array = CreateArray(size);
Fill(array);
Print(array);
int result = Final(array);
Console.WriteLine(result);


