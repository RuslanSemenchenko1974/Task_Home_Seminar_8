//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.

// метод считывает с консоли число тип int
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
// Метод сортирует массив
int[,] SortArray(int[,] array)
{
 
    
    int n=array.GetLength(0);
    int m=array.GetLength(1);
    for (int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
        {  int prom=array[i,0];
           for (int k=0; k<m-j-1; k++)
           {
               if (array[i,k]<array[i,k+1]) 
               {
                prom=array[i,k];
                array[i,k]=array[i,k+1];
                array[i,k+1]=prom;
               }
           }

        }
    }

    
    return array;
}


    
// Метод выводит на экран массив
void ShowArray(int[,] array)
{
    int n=array.GetLength(0);
    int m=array.GetLength(1);
    for (int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
        {                      
            Console.Write(array[i,j]+" ");
        }
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
 Console.WriteLine();
ShowArray(SortArray(array));