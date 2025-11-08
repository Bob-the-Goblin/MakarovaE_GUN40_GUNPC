using System;

class Program
{
    static void Main()
    {
        //First
        int[] fib = new int[10];
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
            Console.WriteLine(fib[i]);
        }

        //Second
        int[] array1 = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i]%2 == 0)
            {Console.WriteLine(array1[i]);}
        }

        //Third
        for (int i = 1; i < 6; i++)
        {
            for (int j = 1; j < 5; j++)
            {
                Console.Write(i*j + ", ");
            }
            Console.WriteLine($"{i*5}\n");
        }

        //The Last
        string password = "qwerty";
        string answer;
        Console.WriteLine("Enter passwrd");
        do { answer = Console.ReadLine(); } while (answer != password);
    }   

}