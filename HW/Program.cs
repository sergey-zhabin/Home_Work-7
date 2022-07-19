
/*void Zadacha47()
{
    int rows =3;
    int colums = 4;
    Random random = new Random();
    double [,] array = new double [ rows, colums]; 
    FillArray(array);
    PrintArray(array);  
}

void FillArray(double [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = Math.Round(random.NextDouble(),1); 
        }
            
    }
}

void PrintArray(double [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();    
    }
}
Zadacha47();*/

void Zadacha50()
{
    
    int rows =4;
    int colums = 5;
    Random random = new Random();
    int [,] array = new int [ rows, colums]; 
    FillArray(array);
    PrintArray(array); 
    
    FindNumber(array);
}


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(1,11); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();   
    }
}
void FindNumber(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    Console.WriteLine("Введите первый индекс числа: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второй индекс числа: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a >= 1 && a <= rows && b >= 1 && b <= colums)
    {
        Console.WriteLine( $" Искомый элемент под индексами: ({a}, {b} = {array[a-1,b-1]})");
    }
    else Console.WriteLine($"Искомого элемента с индексами {a} ,{b} нет");
}   
Zadacha50();


/*void Zadacha52()
{
  
    int rows =4;
    int colums = 5;
    
    Random random = new Random();
    int [,] array = new int [ rows, colums]; 
    FillArray(array);
    PrintArray(array); 
    Console.WriteLine("Вывод массива по столбцам");
    SumMetod(array);
}


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(1,11);            
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();    
    }
}
void SumMetod(int [,] array)
{   

    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int j =0; j < colums; j++)
    {
        double sum =0;
        for (int i =0; i < rows; i++)
        {
            sum += array[i, j];
              
                             
        }
       Console.Write(sum/rows + "\t");
    }
    Console.WriteLine();
   
}

Zadacha52();
/*
void Zadacha46()
{
  
    int rows =4;
    int colums = 5;
    Random random = new Random();
    int [,] array = new int [ rows, colums]; 
    FillArray(array);
    PrintArray(array); 
   
}


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             (array[i, j]) = random.Next(1,11);            
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();    
    }
}

Zadacha46();


/*void Zadacha48()
{
    int m =3;
    int n = 4;
    //Random random = new Random();
    int [,] array = new int[ m, n]; 
    FillArray(array);
    PrintArray(array);  
}

void FillArray(int[,] array)
{
    //Random random = new Random();
    int m =array.GetLength(0);
    int n = array.GetLength(1);
    for ( int i =0; i < m; i++)
    {
        for (int j =0; j < n; j++)
        {
             array[i, j] = i+j; 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int m =array.GetLength(0);
    int n = array.GetLength(1);
        for ( int i =0; i < m; i++)
    {
        for (int j =0; j < n; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();    
    }
}
Zadacha48();*/

/*void Zadacha49()
{
    int rows =6;
    int colums = 6;
    Random random = new Random();
    int [,] array = new int[ rows, colums]; 
    
    FillArray(array);
    PrintArray(array);  
    NewArray(array);
    Console.WriteLine("___________________");
    PrintArray(array);
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             array[i, j] = random.Next(2,5); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();    
    }
}    
void NewArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             if ( i%2 == 0 && j%2 ==0)
                array [i,j] = array [i,j]*array [i,j];  
        }
    }
}
Zadacha49();


void Zadacha51()
{
    int rows =4;
    int colums = 4;
    Random random = new Random();
    int [,] array = new int[ rows, colums]; 
    
    FillArray(array);
    PrintArray(array);  
    SumNumber(array);
    
    
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             array[i, j] = random.Next(2,5); 
        }
            
    }
}

void PrintArray(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
        for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();    
    }
}    
void SumNumber(int [,] array)
{
    int rows =array.GetLength(0);
    int colums = array.GetLength(1);
    int sum =0;
    
    for ( int i =0; i < rows; i++)
    {
        for (int j =0; j < colums; j++)
        {
             if ( i == j)
               sum =sum+ array [i,j]; 
        }
    }
Console.WriteLine(sum);    
}
Zadacha51();*/

