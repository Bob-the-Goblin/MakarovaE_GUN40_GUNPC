using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class SecondTask
    {
        Dictionary<string, int> classmate = new Dictionary<string, int>
        {
            {"Bob", 4 },{"Alex", 3},{"Micha", 5}
        };

        public void Add()
        {
            Console.Write("Enter student name: ");
            string toName = Console.ReadLine();
            Console.Write("Enter the score: ");
            int toMark = int.Parse(Console.ReadLine());
            if (toMark < 2 || toMark > 5)
            {
                Console.WriteLine("wrong Input");
            }
            else
            { classmate.TryAdd(toName, toMark); }
        }

        public void CheckMark()
        {
            Console.Write("Enter name of student: ");
            string toCheack = Console.ReadLine();
            if (classmate.TryGetValue(toCheack, out int value))
            {
                Console.WriteLine($"{toCheack}'s score: {value}");
            }
            else
            {
                Console.WriteLine($"Student whit name - {toCheack}, not exist");
            }
        }

        public void CallTask()
        {
            Add();
            CheckMark();
        }

    }
}
