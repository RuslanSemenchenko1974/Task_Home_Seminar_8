// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
//будет находить строку с наименьшей суммой элементов.

int ReadNamberInt()
{
    int a=0;
    bool parsNIsOk=false;
    while (!parsNIsOk)
    {
        
        parsNIsOk=int.TryParse(Console.ReadLine(), out int numberN);
        if(!parsNIsOk)
        {
            Console.WriteLine("Введено неверно, введите заново:");
        }
        else a=numberN;
    }
    return a;
}

// Метод задает двумерный массив случайных чисел типа int

int [,] GetArrayTwo(int n, int m)
{
        int [,] array= new int[n,m];
        Random rand= new Random();
    for (int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
        {
            array[i,j]=rand.Next(0,10);
           
        }
        
    }
    return array;
}
// Метод находит минимальную строку
int MinStrArray(int[,] array)
{
 
    
    int n=array.GetLength(0);
    int m=array.GetLength(1);
    int summStr=Int32.MaxValue;
    int countI=0;
    for (int i=0; i<n; i++)
    {
        int summ=0;
        for(int j=0; j<m; j++)
        {  
           summ=summ+array[i,j];

        }
        if (summ<summStr)
        {
            summStr=summ;
            countI=i;
        }

    }

    
    return countI;
}


    
// Метод выводит на экран массив
void ShowArray(int[,] array)
{
    int summ=0;
    int n=array.GetLength(0);
    int m=array.GetLength(1);
    for (int i=0; i<n; i++)
    {
        summ=0;
        for(int j=0; j<m; j++)
        {                      
            Console.Write(array[i,j]+" ");
            summ=summ+array[i,j];
        }
      Console.Write(" сумма :"+summ);  
    Console.WriteLine();
    }
}

int n=0;
int m=0;
Console.Clear();

Console.Write("Введите количество строк :");
 n=ReadNamberInt();
Console.Write("Введите количество столбцов :");
 m=ReadNamberInt();
 int [,] array=GetArrayTwo(n,m);
 ShowArray(array);
 Console.WriteLine($"Минимальная строка : {MinStrArray(array)+1}");
