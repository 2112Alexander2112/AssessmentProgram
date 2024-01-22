using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentProgram.Services
{
    internal class Menu
    {
        private string _menu;
        private string[] _menuitem;
        public Menu(string menu, string[] menuitem)
        {
            _menu = menu;
            _menuitem = menuitem;
        }

        public void StartProgram()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=========================");
            Console.WriteLine(_menu);
            Console.WriteLine("=========================");
            for(int i = 0; i < _menuitem.Length; i++)
            {
                Console.WriteLine($" {i + 1}   {_menuitem[i]}");
            }
        }

        public bool AloowProgram()
        {
            Console.WriteLine("Exit? (y/n)");
            string allow = Console.ReadLine();

            return (allow == "y");
        }

        public int ChoiceProgram()
        {
            Console.WriteLine("Choice? ");

            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public void FinishProgram()
        {
            Console.WriteLine("\n\nFinish Program!");
        }
    }
}
