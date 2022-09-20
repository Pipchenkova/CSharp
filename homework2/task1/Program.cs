Console.Clear();
Console.Write("Загадано число: ");
int N = new Random().Next(100,1000);
Console.WriteLine(N);
int a = N/10;
int number = a%10;
Console.WriteLine($"Вторая цифра числа - {number}");


