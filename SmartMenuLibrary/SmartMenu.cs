using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Binding;
using System.Collections;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(@"..\..\MenuSpecDA.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public void Activate()
        {
            {
                string result = Console.ReadLine();

                if (result.Equals("1"))
                {
                    Console.Clear();
                    //result from MenuOne
                    ShowMenu One = new ShowMenu();
                    One.MenuOne();

                }
                else if (result.Equals("2"))
                {
                    Console.Clear();
                    //Result from MenuTwo
                    ShowMenu Two = new ShowMenu();
                    Two.MenuTwo();
                }
                else if (result.Equals("3"))
                {
                    Console.Clear();
                    //result from MenuThree BROKEN
                    ShowMenu Three = new ShowMenu();
                    Three.MenuThree();
                }
                else if (result.Equals("4"))
                {
                    Console.Clear();
                    //result from MenuFour
                    ShowMenu Four = new ShowMenu();
                    Four.MenuFour();
                }
                else if (result.Equals("0"))
                {
                    //Afslut programmet
                    ShowMenu exit = new ShowMenu();
                    exit.ExitMenu();
                }

                if (result.Equals("9"))
                {
                    Console.Clear();
                    //Skift til engelsk menu
                    string[] lines2 = System.IO.File.ReadAllLines(@"..\..\MenuSpecEN.txt");
                    foreach (string line in lines2)
                    {
                        Console.WriteLine(line);

                    }
                    SmartMenu english = new SmartMenu();
                    english.Activate();

                }
            }

        }
  

    }
}
