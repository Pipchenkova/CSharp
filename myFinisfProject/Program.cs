int GetValue(int min, int max)
      {
       return new Random().Next(min, max);
    }
    char [] CreateArray(int value)
     {
     return new char[value];
    }
    void Fill(char[] array)
{
    int size = array.Length;
    for (int i = 0; i<size; i++)
    {
        array[i] =Convert.ToChar(GetValue(0,100));
    }
}

void Print(char[] Array)
{
    Console.WriteLine("[" + string.Join(",", Array) + "]");
}


int size = GetValue(10,20);
char[] array = CreateArray(size);
Fill(array);
Print(array);
