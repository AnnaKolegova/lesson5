void Zadacha38()
{
    Random random = new Random();
    int size=random.Next(4,11);
    Console.WriteLine ($"Размер массива {size}");
    double[] numbers= new double[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine ($"Максимальный элемент {Math.Round(Max(numbers),2)}");
    Console.WriteLine ($"Минимальный элемент {Math.Round(Min(numbers),2)}");
    Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна"+ "\n"+
     $"{Math.Round(Max(numbers)-Min(numbers),2)}");
    
void FillArray(double[]num)
{
    for (int i=0; i<num.Length;i++)
    {
        num[i]=random.NextDouble()*100;
    }
  
}
void PrintArray(double[]num)
{
    for (int i=0; i<num.Length; i++)
    {
        Console.Write(Math.Round (num[i],2)+" ");
        
    }
    Console.WriteLine();
}
double Max(double [] num)
{
    double max=num[0];
    for (int i=1; i<num.Length; i++)
    {
        if (num[i]>max)
        max=num[i];
    }
return max;
}
double Min(double [] num)
{
    double min=num[0];
    for (int i=1; i<num.Length; i++)
    {
        if (num[i]<min)
        min=num[i];
    }
return min;
}

}
Zadacha38();
