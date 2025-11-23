using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ThirdTask
    {
        LinkedList<string> flowers = new LinkedList<string>();


        public void Create()
        {
            Console.WriteLine("Enter 3 flowers: ");
         
            flowers.AddFirst(Console.ReadLine());
            flowers.AddLast(Console.ReadLine());
            flowers.AddLast(Console.ReadLine());
            Console.WriteLine();
        }

        public void ToConsleStraight()
        {
            Console.WriteLine("List of flower straight:");
            foreach (var flower in flowers)
            {  Console.WriteLine(flower); }
            Console.WriteLine();
        }

        public void ToConsoleReverse()
        {
            foreach (var flower in flowers.Reverse())
                { Console.WriteLine(flower); }
        }

        public void CallTask()
        {
            Create();
            ToConsleStraight();
            ToConsoleReverse();
        }
    }
}
