using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using FunctionLibrary;

namespace Binding
{
    public class ShowMenu
    {
        public string Something { get; private set; }


        //Modtag input fra user i smartmenu klassen og hent metode fra funktions klassen
        public void MenuOne()
        {
            Console.WriteLine(Functions.DoThis());//værdi 1 
        }
        internal void MenuTwo()
        {
            Console.WriteLine(Functions.DoThat());//værdi 2 
        }
        internal void MenuThree()
        {
            Console.WriteLine("Error");//værdi 3
        }
        internal void MenuFour()
        {
            Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());//værdi 4
        }
        internal void MenuEnglish()
        {
            //Engelsk menu
            string[] lines = System.IO.File.ReadAllLines(@"..\..\MenuSpecDA.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        internal void ExitMenu()
        {
            Console.WriteLine("Virker ikke helt endnu");
        }
    }
}
