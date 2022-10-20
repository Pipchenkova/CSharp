// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// 1. задаем случайное число - размер массива
// 2. создаем массив
// 3. заполняем случаеными числами от 100 до 999
// 4 печатаеммассив
// 5. проверяем каждое число на четность, суммируем количество

// int value = new Random().Next(4,10);
     
// int[] array = new int[value];

// for( int i=0; i< value; i++)
// {
//     array[i]= new Random().Next(100,999);
// }

// Console.WriteLine(string.Join(",",array));
// int count = 0;
// for( int i=0; i< value; i++)
//  {
//     if( array[i]%2 == 0)
//     {
//         count++;
//    }
//  }
// Console.WriteLine(count);





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
        Array[i] = GetValue(100, 999);
    }
}
void Print(int[] Array)
{
    Console.WriteLine("[" + string.Join(",", Array) + "]");
}
int Final(int[] Array)
{
    int size = Array.Length;
    int count = 0;
    for (int i = 0; i< size; i++)
    {
        if (Array[i] % 2 == 0)
        {
            count++;

        }
    }
    return count;
}
int size = GetValue(4, 10);
int[] Array = CreateArray(size);
Fill(Array);
Print(Array);
int result = Final(Array);
Console.WriteLine(result);




