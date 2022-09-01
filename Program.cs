//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Pows(int arg1, int arg2)
{
    int x = arg1;
    for (int i= 1; i < arg2; i++)
    {
        x *= arg1;
    }
System.Console.WriteLine(x);
}
System.Console.WriteLine("Введите два числа");
Pows(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void summ(string arg3)
{
    int x = 0;
    int y = Convert.ToInt32(arg3);
    for(int i= 0; i < arg3.Length; i++)
    {
        x += y%10;
        y = y/10;
    }
    System.Console.WriteLine(x);
}
System.Console.WriteLine("Введите числo");
summ(Console.ReadLine());

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] mass = new int[8];
Random rand = new Random();
for (int y = 0; y < 8; y++)
{
     mass[y] = rand.Next(0, 100);
}
System.Console.WriteLine(mass);
Console.WriteLine("[{0}]", string.Join(", ", mass));