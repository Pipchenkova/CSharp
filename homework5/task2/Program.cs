// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях

// 1.получаем случайное число - размер массива
// 2. заполняем случайными числами
// 3. печатаем массив
// 4. берем позиции через один. начиная с i=0, и складываем значения

int size = new Random().Next(2,10);
int[] array = new int[size];
for( int i=0; i<size; i++)
{
    array[i] = new Random().Next(-10,10);
}
Console.WriteLine(string.Join(",",array));
int sum = 0;
for( int i=1; i<size; i=i+2)
{
    sum +=array[i];
}
Console.WriteLine(sum);


