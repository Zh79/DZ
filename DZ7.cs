//47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
System.Console.WriteLine("Введите размер массива, через Enter");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array47 = new double[n,m];
Random rand = new Random();
for (int i=0; i < n; i++)
{
    for (int j=0; j < m; j++)
    {
        array47[i,j] = Math.Round(rand.NextDouble()*10-rand.NextDouble()*10, 1);
        System.Console.Write($"{array47[i,j]} ");
   }
   System.Console.WriteLine();
}
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
System.Console.WriteLine("Введите позиции нужного элемента, через Enter");
int m1 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
if (m1<m & n1<n)
{
    System.Console.WriteLine(array47[m1,n1]);
}
else{System.Console.WriteLine("такого элемента нет");}

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] mass = new int[5,5];
Random rand1 = new Random();
double countSA = 0;
for (int k=0; k < 5; k++)
{
    for (int l = 0; l < 5; l++)
    {
        mass[k,l] = rand1.Next(-10,10);
        System.Console.Write($"{mass[k,l]} ");
    }
        System.Console.WriteLine();
}
for (int q = 0; q < 5; q++)
{
    for (int w = 0; w < 5; w++)
    {
        countSA += mass[w,q];
    }
    System.Console.Write($"CA{q} {countSA/5} ");
    countSA=0;
}
