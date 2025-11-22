using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ThirdTask
    {
        LinkedList<string> flower = new LinkedList<string>();


        public void Create()
        {
            Console.WriteLine("Enter 3 flowers: ");
         
            flower.AddFirst(Console.ReadLine());
            flower.AddLast(Console.ReadLine());
            flower.AddLast(Console.ReadLine());
            Console.WriteLine();
        }

        public void ToConsleStraight()
        {
            Console.WriteLine("List of flower straight:");
            foreach (var item in flower)
            {  Console.WriteLine(item); }
            Console.WriteLine();
        }

        public void ToConsoleReverse()
        {
            Console.WriteLine("List of flower reverse");
            var reversFlower = flower.Last;
            while (reversFlower != null)
            {
                Console.WriteLine(reversFlower.Value);
                reversFlower = reversFlower.Previous;
            }
        }

        public void CallTask()
        {
            Create();
            ToConsleStraight();
            ToConsoleReverse();
        }
    }
}
