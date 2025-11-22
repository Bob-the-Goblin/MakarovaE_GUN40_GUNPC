using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class FirstTask
    {
        public List<string> animals = new List<string>() { "sheep", "pig", "cow" };

        public void ToConsole()
        {
            Console.WriteLine("List of animals: ");
            foreach (var anim in animals)
            {   
                Console.WriteLine(anim);
            }
        }

        public void Add()
        {
            Console.Write("Enter animal: ");
            animals.Add(Console.ReadLine());
        }

        public void Replace()
        {
            int middle = animals.Count / 2;
            int lenght = animals.Count - 1;

            string toReplace = animals[lenght];

            for (int i = lenght; i >= middle; i--)
            {
                animals[i] = animals[i - 1];
            }
            animals[middle] = toReplace;
        }

        public void CallTask()
        {
            this.Add();
            this.ToConsole();
            this.Add();
            this.Replace();
            this.ToConsole();
        }
    }
}
