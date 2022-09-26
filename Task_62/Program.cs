// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

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

int[,] array = new int[4,4];

int jB=0, jE=3, iB=0, iE=3, i=0, j=0, p=0;
Console.Clear();
while ((jB<=jE))
{
for (j=jB; j<=jE; j++)
{
    p++;
    array[i,j]=p;
}
j=j-1;
iB=iB+1;

for (i=iB; i<=iE; i++)
{
    p++;
    array[i,j]=p;
}
i=i-1;
jE=jE-1;

for (j=jE; j>=jB; j--)
{
    p++;
    array[i,j]=p;
}
j=j+1;
iE=iE-1;

for (i=iE; i>=iB; i--)
{
    p++;
    array[i,j]=p;
}
i=i+1;
jB=jB+1;
}
ShowArray(array);