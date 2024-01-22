using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssessmentProgram.Services;

namespace AssessmentProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var helper = new Helper();
            var menu = new Menu("Програма оцінювання", new string[]
            {
                "Середня успішність групи по кожному предмету",
                "Cередній рейтинг кожного студента",
                "Вихід"
            });

            bool stop = false;
            do
            {
                menu.StartProgram();
                switch (menu.ChoiceProgram())
                {
                    case 1:
                        helper.DisplayProgramItems();
                        break;
                    case 2:
                        helper.DisplayProgramStudents();
                        break;
                    case 3:
                        stop = true;
                        break;
                }
                if (stop)
                {
                    break;
                }
            } while (menu.AloowProgram());

            menu.FinishProgram();
        }
    }
}
