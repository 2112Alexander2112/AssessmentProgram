using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentProgram.Services
{
    internal class Helper
    {
        private readonly FileManager _file;
        private readonly CalcManager _calc;

        public Helper()
        {
            _file = new FileManager();
            _calc = new CalcManager();
        }
        public void DisplayProgramStudents()
        {
            var students = _file.ReadFile(@"..\..\Data\Students.txt");
            var result = _calc.CalcGrade();
            
            Console.WriteLine("Cередній рейтинг кожного студента\n\n");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{i + 1,5}{students[i], 20}{result[i], 5}");
            }
        }

        public void DisplayProgramItems()
        {
            var items = _file.ReadFile(@"..\..\Data\Items.txt");
            var result = _calc.CalcItems();

            Console.WriteLine("Середня успішність групи по кожному предмету\n\n");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($" {i + 1, 5}{items[i], 15}{result[i],5}");
            }
        }
    }
}
