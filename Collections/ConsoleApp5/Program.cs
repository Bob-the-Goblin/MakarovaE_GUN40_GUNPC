using ConsoleApp5;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        FirstTask first = new FirstTask();
        SecondTask second = new SecondTask();
        ThirdTask third = new ThirdTask();

        Console.Write("Enter 1,2 or 3 to check task by it number: ");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1: 
                first.CallTask();
                break;
            case 2:
                second.CallTask();
                break;
            case 3:
                third.CallTask();
                break;
            default:
                Console.WriteLine("Incrrect Input");
                break;
        }




    }
}


