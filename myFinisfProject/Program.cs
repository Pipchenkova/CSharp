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

int sum(char[]array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i<size; i++)
    {
        if (array[i]>='0' && array[i]<='9')
        {
           count++;
           

        }
    }
    return count;
}
void Final(char[]array,char[] result)
{   
    int size = array.Length;
    int pos = 0;
    for (int i = 0; i<size; i++)
    {
        if (array[i]>='0' && array[i]<='9')
        {
           result[pos]= array[i];
           pos++;
           
        }
    }
}

int size = GetValue(10,20);
char[] array = CreateArray(size);
Fill(array);
Print(array);
int count = sum(array);
Console.WriteLine(count);
char[]result=CreateArray(count);
Final(array,result);
Print(result);


