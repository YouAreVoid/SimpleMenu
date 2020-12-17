using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu
{
    class Program
    {
        #region Main
        static void Main()
        {
            Logo();
            Console.Title = "Simple Menu Made By You'reVoid";
            //options-start
            Colorful.Console.WriteLine("[1] Option 1", Color.Cyan);
            Colorful.Console.WriteLine("[2] Option 2", Color.Cyan);
            Colorful.Console.WriteLine("[3] Option 3", Color.Cyan);
            Colorful.Console.WriteLine("[4] Option 4", Color.Cyan);
            Colorful.Console.WriteLine("[5] Option 5" + Environment.NewLine, Color.Cyan);
            Colorful.Console.Write("---> ", Color.Cyan);
            string Option = Console.ReadLine();
            //options-end
            if (Option == "1")
            {
                Console.Clear();
                SubMenu1();
            }
            else if (Option == "2")
            {
                Console.Clear();
                SubMenu2();
            }
            else if (Option == "3")
            {
                Console.Clear();
                SubMenu3();
            }
            else if (Option == "4")
            {
                Console.Clear();
                SubMenu4();
            }
            else if (Option == "5")
            {
                Console.Clear();
                SubMenu5();
            }
            else
            {
                //This is if they put a number which doesn't correspond to any of the options.
                Colorful.Console.WriteLine(Option + " was not an valid option." + Environment.NewLine + "Press Anything to Return to Main Menu.", Color.Cyan);
                Console.ReadLine();
                Console.Clear();
                Program.Main();
            }
        }
        #endregion

        #region Logo
        static string Logo()
        {
            //logo- start
            string Return = "";
            Colorful.Console.WriteLine("██╗      ██████╗  ██████╗  ██████╗ ", Color.Cyan);
            Colorful.Console.WriteLine("██║     ██╔═══██╗██╔════╝ ██╔═══██╗", Color.Cyan);
            Colorful.Console.WriteLine("██║     ██║   ██║██║  ███╗██║   ██║", Color.Cyan);
            Colorful.Console.WriteLine("██║     ██║   ██║██║   ██║██║   ██║", Color.Cyan);
            Colorful.Console.WriteLine("███████╗╚██████╔╝╚██████╔╝╚██████╔╝", Color.Cyan);
            Colorful.Console.WriteLine("╚══════╝ ╚═════╝  ╚═════╝  ╚═════╝ ", Color.Cyan);
            Console.WriteLine("");
            return Return;
            //logo-end
        }
        //http://patorjk.com/software/taag/#p=display&f=ANSI%20Shadow&t=Logo to change the text of The Logo.
        #endregion

        #region SubMenus
        static void SubMenu1()
        {
            Console.Title = "Simple Menu Made By You'reVoid - SubMenu1";
            Logo();
            Colorful.Console.WriteLine("SubMenu1 Opened, Option 1 was chosen." + Environment.NewLine + "Press Anything to Return to Main Menu", Color.Cyan);
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }

        static void SubMenu2()
        {
            Console.Title = "Simple Menu Made By You'reVoid - SubMenu2";
            Logo();
            Colorful.Console.WriteLine("SubMenu2 Opened, Option 2 was chosen." + Environment.NewLine + "Press Anything to Return to Main Menu", Color.Cyan);
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }

        static void SubMenu3()
        {
            Console.Title = "Simple Menu Made By You'reVoid - SubMenu3";
            Logo();
            Colorful.Console.WriteLine("SubMenu3 Opened, Option 3 was chosen." + Environment.NewLine + "Press Anything to Return to Main Menu", Color.Cyan);
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }

        static void SubMenu4()
        {
            Console.Title = "Simple Menu Made By You'reVoid - SubMenu4";
            Logo();
            Colorful.Console.WriteLine("SubMenu4 Opened, Option 4 was chosen." + Environment.NewLine + "Press Anything to Return to Main Menu", Color.Cyan);
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }

        static void SubMenu5()
        {
            Console.Title = "Simple Menu Made By You'reVoid - SubMenu5";
            Logo();
            Colorful.Console.WriteLine("SubMenu5 Opened, Option 5 was chosen." + Environment.NewLine + "Press Anything to Return to Main Menu", Color.Cyan);
            Console.ReadLine();
            Console.Clear();
            Program.Main();
        }
        #endregion
    }
}
