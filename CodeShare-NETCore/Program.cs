using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace CodeShare_NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyCsvhelper myCsvhelper = new MyCsvhelper();

            myCsvhelper.ReadScores();

            myCsvhelper.ScoresCache.Add(new Score("Player1", 155));
            myCsvhelper.ScoresCache.Add(new Score("Player2", 179));
            myCsvhelper.ScoresCache.Add(new Score("Nyro", 6969));

            myCsvhelper.WriteScores();



            Console.ReadLine();
        }
    }
}
