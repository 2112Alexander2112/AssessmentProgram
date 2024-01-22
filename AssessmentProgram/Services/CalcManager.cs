using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentProgram.Services
{
    internal class CalcManager
    {
        private readonly FileManager _file;

        public CalcManager()
        {
            _file = new FileManager();
        }
        public int[] CalcGrade()
        {
            var matrix = _file.ReadGrade(@"..\..\Data\grade.txt");
            int[] result = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < matrix[i].Length; j++)
                    rowSum += matrix[i][j];

                result[i] = rowSum / matrix[i].Length;
            }
            return result;
        }

        public int[] CalcItems()
        {
           var matrix = _file.ReadGrade(@"..\..\Data\grade.txt");
           int rowCount = matrix.Length;
           int colCount = matrix.Max(row => row.Length);
           int[] result = new int[colCount];
            for (int j = 0; j < colCount; j++)
            {
                int sum = 0;
                for (int i = 0; i < rowCount; i++)
                    if (j < matrix[i].Length)
                        sum += matrix[i][j];

                result[j] = sum / rowCount;
            }
            return result;
        }
    }
}
