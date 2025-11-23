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
            Console.Write("Enter animal: ");
            string newAnim = (Console.ReadLine());
            animals.Insert(animals.Count/2, newAnim);
        }

        public void CallTask()
        {
            this.Add();
            this.ToConsole();
            this.Replace();
            this.ToConsole();
        }
    }
}
