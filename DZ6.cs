//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
int count = 0;
int pol(string n)
{
    
    if (n == "STOP") return count;
    
    else if (Convert.ToDouble(n) > 0) 
     count++;
     System.Console.WriteLine("Введите число. Для подсчета введите (STOP)");
     return pol(Console.ReadLine());
     
}
System.Console.WriteLine("Введите число. Для подсчета введите (STOP)");
System.Console.WriteLine(pol(Console.ReadLine()));
System.Console.WriteLine("Для нахождения точки пересечения двух прямых, введите число b1");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b2");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = 0; 
double y = 0;
if (k1 == k2 & b2 == b1)
{
    System.Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    System.Console.WriteLine("Прямые параллельны");
}
else {
x = (b1-b2) / (k2-k1);
y = k1*x +b1;
System.Console.WriteLine($"({x};{y})");
}
