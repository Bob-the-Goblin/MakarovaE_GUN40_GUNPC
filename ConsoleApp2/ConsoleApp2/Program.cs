using System;
using System.Runtime.Versioning;

class Program
    {
    static void Main()
    {
        //First    
        int[] fib = new int[8];
        fib.SetValue(0, 0);
        fib.SetValue(1, 1);
        for (int i = 0; i < fib.Length; i++)
        {
            if (i > 1)
            {
                var a = fib[i - 2];
                var b = fib[i - 1];
                fib.SetValue(a + b, i);
            }
        }

        //Second
        string[] month = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", };

        //Third
        double[,] matrix = new double[3, 3];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Pow(j + 2, i + 1);
            }
        }

        //Fourth
        double[][] jag = new double[3][];
        jag[0] = new double[5] { 1, 2, 3, 4, 5 };
        jag[1] = new double[2] { Math.E, Math.PI };
        jag[2] = new double[4] { Math.Log(1), Math.Log(10), Math.Log(100), Math.Log(1000) };


        //Fifth
        int[] array = { 1, 2, 3, 4, 5 }; int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

        for (int i = 0; i < 3; i++)
        {
            array2[i] = array[i];

        }

        //Sixth
        Array.Resize(ref array, array.Length * 2);
        Console.WriteLine(array.Length);
    }
    }

