//Задача 64: 

string PromNM (int M, int N)
{
    string result = string.Empty;
    if (M>N) return "";
    else return ($"{M}, {PromNM(M+1,N)}");
}

System.Console.WriteLine(PromNM(4,10));

//Задача 66: 

int SummNM (int M, int N)
{
    if (M>N) return 0;
    else return M + SummNM(M+1,N);
}

System.Console.WriteLine(SummNM(4,8));

//Задача 68: 

double Ackermann(double m, double n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackermann(m-1, 1);
    return Ackermann(m-1, Ackermann(m, n-1));
}

System.Console.WriteLine(Ackermann(3,3));

