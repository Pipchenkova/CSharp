// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введтите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введтите второе число:");
int b =Convert.ToInt32(Console.ReadLine());
if (a > b){
    Console.Write("наибольшее число ");
    Console.WriteLine(a);
    Console.Write("наименьшее число ");
    Console.WriteLine(b);

}
else{
    Console.Write("наибольшее число ");
    Console.WriteLine(b);
    Console.Write("наименьшее число ");
    Console.WriteLine(a);

}

