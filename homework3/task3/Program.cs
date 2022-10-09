//Задача 23

//Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

double[] Cub(int number)
{
    double[] res1 = new double[number];
    for (int i = 0; i < number; i++)
    {
        res1[i] = Math.Pow(i + 1, 3);
    }
    return res1;
}

Console.WriteLine(String.Join(",", Cub(5)));

