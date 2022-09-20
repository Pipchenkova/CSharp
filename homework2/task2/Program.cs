Console.Clear();
Console.Write("Задано число: ");
 //int N = new Random().Next();
 int N = 0;
 Console.WriteLine(N);
 if(N/100==0){
    Console.WriteLine("В числе менее трех цифр");
 }
else{
    int count = 0;
    int a = N;
    while(Math.Abs(a)/10>0){
        count ++;
        a = a/10;
    }
    int number = Math.Abs(N)/Convert.ToInt32(Math.Pow(10,(count - 2)));
    int number1 = number%10;
    Console.WriteLine($"Третья цифра числа - {number1}");
}