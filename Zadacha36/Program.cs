void Zadacha36()
{
    Random random = new Random();
    int size=random.Next(4,11);
    Console.WriteLine ($"Размер массива {size}");
    int[] numbers= new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    
    Console.WriteLine ($"Сумма элементов с нечетными индексами равна {Summa(numbers)}");
    
void FillArray(int[]num)
{
    for (int i=0; i<num.Length;i++)
    {
        num[i]=random.Next(0, 100);
    }
  
}
void PrintArray(int[]num)
{
    for (int i=0; i<num.Length; i++)
    {
        Console.Write(num[i]+" ");
        
    }
    Console.WriteLine();
}
int Summa(int [] num)
{
    int sum=0;
    for (int i=0; i<num.Length-1; i++)
    {
        i+=1;
        sum+=num[i];
    }
return sum;
}

}
Zadacha36();
