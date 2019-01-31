using CsvHelper.Configuration.Attributes;
using System;

namespace ClassLibrary1
{
    public class Score
    {
        [Index(0)]
        public string Player { get; set; }
        [Index(1)]
        public int Points { get; set; }

        public Score (string player, int points)
        {
            Player = player;
            Points = points;
        }
    }
}
