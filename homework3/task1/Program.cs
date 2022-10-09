//ввести пятизначное число
//создать массив
// заполнить его цифрами числа
// проверить , что 0-вой = 4му, 1-й = 3ему
// вывести да или нет 
Console.Clear();

int number = new Random().Next(10000, 99999);
Console.WriteLine($" Задано число {number}");


int[] Create(int len)
{
    return new int[len];

}
//int[] array = new int[5];
void Fill(int[] array)
{

    for (int i = 0; i < 5; i++)
    {
        array[4 - i] = number % 10;
        number = number / 10;
    }
}
    void Find(int[] array)
    {

        if (array[0] == array[4] && array[1] == array[3])
        {
            Console.WriteLine(" Число полиндром");

        }
        else
        {
            Console.WriteLine(" Число  НЕ полиндром");

        }
        //Console.WriteLine(string.Join(",", array));
    }

    int[] array = Create(5);
    Fill(array);
    Find(array);









