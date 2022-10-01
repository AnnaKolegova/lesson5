void Zadacha38()
{
    Random random = new Random();
    int size=random.Next(4,11);
    Console.WriteLine ($"Размер массива {size}");
    double[] numbers= new double[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine ($"Максимальный элемент {Max(numbers)}");
    Console.WriteLine ($"Минимальный элемент {Min(numbers)}");
    Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна"+ "\n"+
     $"{Max(numbers)-Min(numbers)}");
    
void FillArray(double[]num)
{
    for (int i=0; i<num.Length;i++)
    {
        num[i]=Convert.ToDouble(random.Next(-10000, 10000)/100.0);
    }
  
}
void PrintArray(double[]num)
{
    for (int i=0; i<num.Length; i++)
    {
        Console.Write(num[i]+" ");
        
    }
    Console.WriteLine();
}
double Max(double [] num)
{
    double max=Math.Abs(num[0]);
    for (int i=1; i<num.Length; i++)
    {
        if (Math.Abs(num[i])>max)
        max=Math.Abs(num[i]);
    }
return max;
}
double Min(double [] num)
{
    double min=Math.Abs(num[0]);
    for (int i=1; i<num.Length; i++)
    {
        if (Math.Abs(num[i])<min)
        min=Math.Abs(num[i]);
    }
return min;
}

}
Zadacha38();


