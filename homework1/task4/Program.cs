Console.Clear();
Console.Write("Дано число: ");
int N = new Random().Next(1,21);
//int N = 1;
Console.WriteLine(N);
int start = 2;
if( N>1){
Console.WriteLine("Четные числа, которые в него входят: ");
while(start<=N){
    Console.WriteLine(start);
    start +=2;
}
}
else{
   Console.WriteLine(" Четных чисел нет");
}

