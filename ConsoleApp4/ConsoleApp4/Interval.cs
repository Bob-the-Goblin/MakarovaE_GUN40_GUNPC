using System;

    public struct Interval
    {

        public int Min { get; }
        public int Max { get; }
        public int Get { get; }


        public Interval(int min, int max)
        {
        Min = min;
        Max = max;

        Random rand = new Random();
        Get = rand.Next(Min, Max);

            if (min > max)
            {
                int toReplace = min;
                min = max;
                max = toReplace;
            }
            if (min < 0) { min = 0; Console.WriteLine("Incorrect Input"); }
            if (max < 0) { max = 0; Console.WriteLine("Incorrect Input"); }
            if (max == min) { max += 10; Console.WriteLine("Incorrect Input"); }
        }
    }




