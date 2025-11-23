using System;

    public struct Interval
    {

        public int Min { get; }
        public int Max { get; }
        public int Get ()
        {
        Random rand = new Random();
        return rand.Next(Min, Max + 1); }


        public Interval(int min, int max)
        {
        Min = min;
        Max = max;

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




