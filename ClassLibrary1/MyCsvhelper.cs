using CsvHelper;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary1
{
    public class MyCsvhelper
    {
        private const string dataFile = @"D:\source\repos\CodeShare-NETCore\score.csv";
        public List<Score> ScoresCache { get; set; } = new List<Score>();

        public void ReadScores(bool useHeader = true, string path = dataFile)
        {
            if (!File.Exists(path))
                return;

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                IEnumerable<Score> records = csv.GetRecords<Score>();
                records.ToList().ForEach(x => ScoresCache.Add(x));
            }

        }

        public void WriteScores(List<Score> Scores = null, string path = dataFile)
        {
            if (Scores == null)
                Scores = ScoresCache;

            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(Scores);
            }
        }
    }
}
