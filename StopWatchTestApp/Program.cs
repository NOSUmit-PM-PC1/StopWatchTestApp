using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StopWatchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Stopwatch.IsHighResolution);
/*
            Stopwatch stopwatch = new Stopwatch();
            List<int> vs = new List<int>();
            Random random = new Random();
            List<string> result = new List<string>();
 

            for(int i=0; i<10000; i++)
            {
                vs.Add(random.Next(1000));
            }

            List<int> vs1 = new List<int>(vs);
            List<int> vs2 = new List<int>(vs);
            vs.Sort();

            stopwatch.Start();
            
            string s = "";
            for (int i = 0; i < vs.Count; i++)
                s = s + vs[i] + "\n";

           
            stopwatch.Stop();

            result.Add("Concatination " + stopwatch.Elapsed);

            stopwatch.Restart();
           
            Console.WriteLine(string.Join('\n', vs));
            stopwatch.Stop();

            result.Add("Join " + stopwatch.Elapsed);

            stopwatch.Restart();

            for (int i = 0; i < vs.Count; i++)
                Console.WriteLine(vs[i]);
            stopwatch.Stop();

            result.Add("Stream write " + stopwatch.Elapsed);

            Console.WriteLine(string.Join('\n', result));


            /*
            Console.WriteLine("Elapsed " + stopwatch.Elapsed);
            Console.WriteLine("ElapsedMilliseconds " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("ElapsedTicks " + stopwatch.ElapsedTicks);
            Console.WriteLine("Частота " + Stopwatch.Frequency);
            */
           
        }
    }
}
