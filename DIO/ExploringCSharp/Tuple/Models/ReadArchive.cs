using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuple.Models
{
    public class ReadArchive
    {
        public (bool Success, string[] Lines, int TotalLines) ReadingArchive(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Count());
            } catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}