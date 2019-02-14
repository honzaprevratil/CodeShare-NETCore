using ConvertorLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShare_NETCore
{
    public class Score : DataClass
    {
        public string Player { get; set; }
        public int Points { get; set; }

        public Score() { }

        public Score(string player, int points)
        {
            Player = player;
            Points = points;
        }
    }
}
