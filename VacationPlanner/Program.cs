using System;
using System.Globalization;
using System.Linq;
using VacationPlanner.Models;

namespace VacationPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Handler.MainMenu();
            }          
        }
    }
}
