void Zadacha34()
{
    Random random = new Random();
    int size=random.Next(4,11);
    Console.WriteLine ($"Размер массива {size}");
    int[] numbers= new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Res(numbers);
    
void FillArray(int[]num)
{
    for (int i=0; i<num.Length;i++)
    {
        num[i]=random.Next(100, 1000);
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
void Res(int [] num)
{
    int k=0;
    for (int i=0; i<num.Length; i++)
    {
        if (num[i]%2==0)
        k+=1;
    }
Console.WriteLine ($"В массиве {k} четных чисел");
}


}
Zadacha34();