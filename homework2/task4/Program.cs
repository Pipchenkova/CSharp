Console.Clear();
Console.Write("Задан массив чисел: ");
int size = 7;
int[] sourse = new int[size];
for(int i = 0; i<size; i++)
{
    sourse[i] = new Random().Next(1,10);
    Console.Write(sourse[i] + " ");
}
int Total1 = 0;
for(int i = 0; i<size; i++)
{
Total1 += sourse[i];
}
double Avg= Convert.ToDouble(Total1)/Convert.ToDouble(size);
Console.Write(" Среднеaрифметическое = ");
Console.Write( Avg);








