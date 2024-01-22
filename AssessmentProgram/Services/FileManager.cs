using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssessmentProgram.Services
{
    internal class FileManager
    {
        public int[][] ReadGrade(string file)
        {
            var text = string.Empty;
            using (var fs = new FileStream(file, FileMode.Open))
            using (var sr = new StreamReader(fs))
                text = sr.ReadToEnd();

            string[] rowsArray = text.Trim().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = rowsArray.Length;
            int[][] matrix = new int[rows][];
            int cols = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] parts = rowsArray[i].Split();
                if (i == 0)
                    cols = parts.Length;
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                    if (j < parts.Length)
                        if (int.TryParse(parts[j], out int value))
                            matrix[i][j] = value;
            }
            return matrix;
        }
    

        public string[] ReadFile(string file)
        {
            var buff = string.Empty;
            using (var fs = new FileStream(file, FileMode.Open))
            using (var sr = new StreamReader(fs))
                buff = sr.ReadToEnd();

            string[] parts = buff.Trim().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return parts;
        }
    }
}
