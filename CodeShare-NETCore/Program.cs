using ConvertorLib;
using System;
using System.Collections.Generic;

namespace CodeShare_NETCore
{
    class Program
    {
        public static List<Score> DataList = new List<Score>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // TEST
            string input = @"D:\source\repos\CodeShare-NETCore\score.csv";      // input path text;
            string output = @"D:\source\repos\CodeShare-NETCore\score.json";    // output path text;

            List<Score> DataList = Convertor.Read<Score>(input);
            //Convertor.Convert(output, input); //reverse test

            Console.ReadLine();
        }
    }
}
