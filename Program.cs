//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void chetn(int[] m)
{
    int count = 0;
    for (int i = 0; i<m.Length; i++)
    {
        if (m[i]%2==0)
        {
            count++;
        }
    }
    
    System.Console.WriteLine(count);
}
int[] mass34 = new int[10];
Random rand = new Random();
for (int i=0; i < 10; i++)
{
    mass34[i] = rand.Next(100,1000);
    System.Console.WriteLine(mass34[i]);
    }
chetn(mass34);
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
System.Console.WriteLine(' ');
void nechetn(int[] m)
{
    int count = 0;
    for (int i = 1; i<m.Length; i=i+2)
    {
        count +=m[i];
    }
    
    System.Console.WriteLine(count);
}
int[] mass36 = new int[10];
Random rand1 = new Random();
for (int i=0; i < 10; i++)
{
    mass36[i] = rand1.Next(-10, 10);
    System.Console.WriteLine(mass36[i]);
    }
nechetn(mass36);
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
System.Console.WriteLine(' ');

double[] mass38 = new double[10];
Random rand2 = new Random();
for (int i=0; i < 10; i++)
{
    mass38[i] = rand2.NextDouble()*10;
   System.Console.WriteLine(mass38[i]);
}
System.Console.WriteLine(mass38.Max()-mass38.Min());

//промежуточный вывод элементов массива сделан для наглядности
