class Program
{

    static void Main()
    {
        Console.WriteLine("Введите n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите левую границу диапазона чисел a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите правую границу диапазона чисел b:");
        int b = int.Parse(Console.ReadLine());

        if (a >= b)
        {
            Console.WriteLine("Ошибка! Левая граница должна быть строго меньше правой!");
        }
        int[,] ATable = ATab(a, b, n);
        int[,] BTable = BTab(a, b, n);

        while(true)
        {
            Console.WriteLine("Выберите то, что вы хотите сделать с матрицей: 1 - Заполнить матрицы и вывести матрицы на экран, 2 - Выполнить сложение матриц, 3 - Выполнить вычитание матриц.");
            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("{0,3}", ATable[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("{0,3}", BTable[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 2:

                    int[,] sumMatrix2 = sumMatrix(ATable, BTable, n);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("{0,3}", sumMatrix2[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    int[,] minusMatrix2 = minusMatrix(ATable, BTable, n);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("{0,3}", minusMatrix2[i, j]);
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        } 
}

static int[,] ATab(int a, int b, int n)
{
    Random random = new Random();
    int[,] ATable = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            ATable[i, j] = random.Next(a, b);
        }
    }
    return ATable;
}

static int[,] BTab(int a, int b, int n)
{
    Random random = new Random();
    int[,] BTable = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            BTable[i, j] = random.Next(a, b);
        }
    }
    return BTable;
}

static int[,] sumMatrix(int[,] ATable, int[,] BTable, int n)
{
    int[,] sum = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i, j] = ATable[i, j] + BTable[i, j];
        }
    }
    return sum;
}

static int[,] minusMatrix(int[,] ATable, int[,] BTable, int n)
{
    int[,] sum = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i, j] = ATable[i, j] - BTable[i, j];
        }
    }
    return sum;
}


}