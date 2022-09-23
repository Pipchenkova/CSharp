Console.Clear();
Console.Write("Сегодня день: ");
int N = new Random().Next(1,8);
Console.WriteLine(N);
if (N>5)
{
  Console.WriteLine("Ура! Выходной"); 
}
else{
    Console.WriteLine(" Иди работай");
}



