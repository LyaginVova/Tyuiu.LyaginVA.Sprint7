using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.LyaginVA.Sprint7.Project.V4.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string fileDta = File.ReadAllText(filePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length < 2)
            {
                return null;
            }

            int rows, cols;
            rows = lines.Length - 1; 
            cols = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, cols];

            for (int i = 1; i < lines.Length; i++) 
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i - 1, j] = Convert.ToString(line_r[j]);
                }
            }

            return arrayValues;
        }

    }
}
