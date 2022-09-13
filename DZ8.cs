int[,] GetArray(int m, int n){
    var result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }

    return result;
}

void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] SortMaxMinArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int j = 0; j < arr.GetLength(1)-1; j++)
            {
                if (arr[i,j]<arr[i,j+1])
                {
                    int x = arr[i,j];
                    arr[i,j]=arr[i,j+1];
                    arr[i,j+1] = x;
                }
                
            }
        }
    }
    return arr;
}

void MinSumm(int[,] arr){
    int indexMin = 0;
    int min = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        int summ = 0;     
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i,j];
                
        }
        if (i == 0) min = summ; 
        if (min > summ)
        {
            indexMin = i;
            min = summ;
        }
    }
    System.Console.WriteLine($"{indexMin+1} строка");
}

int[,] MultipMatrArr(int[,] arr1, int[,] arr2){
    var result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                int value = 0;
                for (int n = 0; n < arr1.GetLength(1); n++)
                    {
                        value = value + arr1[i,n]*arr2[n,j];
                    }
                result[i,j]=value;
            }
        }
    }
    return result;
}

int[,,] GetArray3(int m, int n, int k){
    var result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int b = 0; b < k; b++)
            {
                result[i, j, b] = 15+i*10+j*11+b*12; //неповторяющихся
            }
        }
    }
    return result;
}

void PrintArray3(int[,,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int b = 0; b < arr.GetLength(2); b++){
                Console.Write($"{arr[i, j, b]}({i},{j},{b}) ");
            }
            System.Console.WriteLine();
        }
        
    }
}

int[,] Spiral(int m, int n){
    var result = new int[m, n];
    int iX = 0, iY = 0, jX = 0, jY = 0;
    int M = m, N = n;
    int k = 1, i = 0, j = 0;
    while (k <= M * N){
        result[i,j] = k;
        if (i == iX && j < M - jY - 1) j++;
        else if (j == M - jY - 1 && i < N - iY - 1) i++;
        else if (i == N - iY  -1 && j > jX) j--;
        else i--;
        if ((i == iX +1) && (j == jX) && (jX != M - jY )){
            iX++;
            jY++;
            jX++;
            iY++;
        }
        k++;
    }
    return result;
}


System.Console.WriteLine("Задача 54");
int[,] arr = GetArray(3,3);
PrintArray(SortMaxMinArray(arr));
System.Console.WriteLine("Задача 56");
MinSumm(arr);
System.Console.WriteLine("Задача 58");
int[,] arr1 = GetArray(5,2);
int[,] arr2 = GetArray(2,5);
PrintArray(arr1);
System.Console.WriteLine();
PrintArray(arr2);
System.Console.WriteLine();
PrintArray(MultipMatrArr(arr1,arr2));
System.Console.WriteLine("Задача 60");
PrintArray3(GetArray3(2,2,2));
System.Console.WriteLine("Задача 62");
PrintArray(Spiral(4,4));





