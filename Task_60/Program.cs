// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

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
int n=0;
int m=0;
int l=0;

Console.Clear();

Console.Write("Введите  размерность 1:");
 n=ReadNamberInt();
Console.Write("Введите  размерность 2:");
 m=ReadNamberInt();
Console.Write("Введите  размерность 3:");
 l=ReadNamberInt();
 int size=l*m*n;
 if (size>89)
 {
    Console.WriteLine("Введено неверно"); 
return;
 }
 // создаем одномерный массив размерностью равный трехмерному
 // и проверяем на повторяемость
 int[] array= new int[size];
 int i=0;
 Random rand = new Random();
 bool check=true;
 while (i<size)
 {
    int c=rand.Next(10,99);
    for (int j=0; j<i; j++)
    {
        if (array[j]==c) check=false;
    }
    if(check) 
    {
        array[i]=c;
        i++;
    }
    else check=true;
 }
int count=0;
// Создаем и заполняем трехмерный массив
int[,,] arrayThird = new int[n,m,l];
for (i=0; i<n; i++)
    for (int j=0; j<m; j++)
    {
            for(int k=0; k<l; k++)
        {
            arrayThird[i,j,k]=array[count];
            count++;
            Console.Write($"[{i},{j},{k}]={arrayThird[i,j,k]} ");
        }
        Console.WriteLine();
    }
 


