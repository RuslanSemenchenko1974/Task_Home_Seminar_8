// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int [,] GetArray(int n, int m)
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

// Метод находит произведение двух матриц
int[,] MultArray(int[,] array1, int[,] array2)
{
 
    int n=array1.GetLength(0);
    int z=array1.GetLength(1);
    int m=array2.GetLength(1);
    int[,] multArray=new int[n,m];
    for (int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {  
        int summ=0;
            for (int k=0; k<z; k++)
            summ=summ+array1[j,k]*array2[k,i];
        multArray[j,i]=summ;
        }
    }

    
    return multArray;
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

int n1=0;
int m1=0;
int n2=0;
int m2=0;
Console.Clear();

Console.Write("Введите количество строк 1 матрицы:");
 n1=ReadNamberInt();
Console.Write("Введите количество столбцов 1 матрицы:");
 m1=ReadNamberInt(); 
 int [,] array1=GetArray(n1,m1);
bool check=true;
while (check)
    {
    Console.Write("Введите количество строк 2 матрицы:");
    n2=ReadNamberInt();
    if (n2!=m1) Console.WriteLine("Введено неверно");
    else check=false;
    }
 
    Console.Write("Введите количество столбцов 2 матрицы:");
    m2=ReadNamberInt();

 int[,] array2=GetArray(n2,m2);

 ShowArray(array1);
 Console.WriteLine();
 ShowArray(array2);
 Console.WriteLine();
 int [,] result=MultArray(array1,array2);
 ShowArray(result);
