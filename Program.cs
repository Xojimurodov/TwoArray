using System.ComponentModel.DataAnnotations;
using System.Numerics;

class Program 
{
    public static void Main()
    {
        int[,] array = 
        { 
            { 3, 8, 1 },
            { 7, 4, 9 },
            { 2, 5, 6 } 
        };

        BigNumber(array);

        // int[,] array = 
        // { 
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 } 
        // };

        // int[] sum = new int[array.GetLength(0)];

        // sum = SumOfRows(array);

        // for(int i = 0; i < sum.Length; i++)
        // {
        //     Console.Write(sum[i] + " ");
        // }

        // int[,] array = 
        // { 
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 } 
        // };

        // SumOfLength(array);

        // int[,] array = 
        // {
        //     { -1, 2, -3 },
        //     { 4, -5, 6 },
        //     { -7, 8, -9 }
        // };

        // PlusNumber(array);

        // int[,] array = 
        // { 
        //     { 10, 15, 5 },
        //     { 7, 20, 30 },
        //     { 25, 3, 12 }
        // };

        // TheSmallNumber(array);

        // int[,] array = 
        // {
        //     { 2, 3, 4 },
        //     { 5, 6, 7 },
        //     { 8, 9, 10 }
        // };

        // OddNumber(array);

        // int[,] array = 
        // {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };


        // array = NolNumbers(array);

        // for(int i = 0; i < array.GetLength(0); i++)
        // {
        //     for(int j = 0; j < array.GetLength(1); j++)
        //     {
        //         Console.Write(array[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }

    }

    private static int[,] NolNumbers(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
            }
        }

        return array;
        
    }

    private static void OddNumber(int[,] array)
    {
        int sum = 0;
         for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i, j] %2 != 0)
                {
                    sum++;
                }
            }
        }

        Console.WriteLine($"Toq sonlar soni: {sum}");
    }

    private static void TheSmallNumber(int[,] array)
    {
        int sum = array[0, 0];
         for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i, j] < sum)
                {
                    sum = array[i, j];
                }
            }
        }

        Console.WriteLine($"ENg kichik son: {sum}");
    }

    private static void PlusNumber(int[,] array)
    {
        int sum = 0;
         for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i, j] > 0)
                {
                    sum++;
                }
            }
        }

        Console.WriteLine($"Musbat elementlar soni: {sum}");
    }

    private static void SumOfLength(int[,] array)
    {
        int sum = 0;
         for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(i == j)
                {
                    sum += array[i, j];
                }
            }
        }

        Console.WriteLine(sum);
    }

    private static int[] SumOfRows(int[,] array)
    {
        int[] sum = new int[array.GetLength(0)];

        for(int i = 0; i < array.GetLength(0); i++)
        {
            int son = 0;
            for(int j = 0; j < array.GetLength(1); j++)
            {
                son += array[i, j];
            }
            sum[i] = son;
        }

        return sum;
    }

    private static void BigNumber(int[,] array)
    {
        int max = array[0, 0];
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(max < array[i, j])
                {
                    max = array[i, j];
                }
            }
        }

        Console.WriteLine(max);

    }
}