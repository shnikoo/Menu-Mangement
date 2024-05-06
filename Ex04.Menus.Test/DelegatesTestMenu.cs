using System;
using System.Linq;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{ 
    internal class DelegatesTestMenu
    {
        internal MainMenu m_MainMenu;
        internal DelegatesTestMenu()
        {
            this.m_MainMenu = buildTestMenu();
            setFunctionItemsInTestMenu(m_MainMenu);
        }

        private static MainMenu buildTestMenu()
        {
            MainMenu menu = new MainMenu("Delegates Main Menu");

            try
            {
                menu.AddMenuItems(null, eItemType.SubMenu, "Show Date/Time", "Version and Capitals");
                menu.AddMenuItems(new int[] { 1 }, eItemType.FunctionItem, "Show Time", "Show Date");
                menu.AddMenuItems(new int[] { 2 }, eItemType.FunctionItem, "Count Capitals", "Show Version");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return menu;
        }

        private static void setFunctionItemsInTestMenu(MainMenu i_Menu)
        {
            try
            {
                FunctionItem functionItem = null;

                functionItem = i_Menu.FindMenuItem(new int[] { 1, 1 }) as FunctionItem;
                functionItem.FunctionBecameChosen += new Action(showTimeFunction_Chosen);
                functionItem = i_Menu.FindMenuItem(new int[] { 1, 2 }) as FunctionItem;
                functionItem.FunctionBecameChosen += new Action(showDateFunction_Chosen);
                functionItem = i_Menu.FindMenuItem(new int[] { 2, 1 }) as FunctionItem;
                functionItem.FunctionBecameChosen += new Action(countCapitalLetters_Chosen);
                functionItem = i_Menu.FindMenuItem(new int[] { 2, 2 }) as FunctionItem;
                functionItem.FunctionBecameChosen += new Action(showVersionFunction_Chosen);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void showTimeFunction_Chosen()
        {
            Console.WriteLine("Time of the day is: {0}{1}", DateTime.Now.ToString("T"), Environment.NewLine);
        }

        private static void showDateFunction_Chosen()
        {
            Console.WriteLine("Today's date is: {0}{1}", DateTime.Now.ToString("d"), Environment.NewLine);
        }

        private static void countCapitalLetters_Chosen()
        {
            int capitalletterscount = 0;
            Console.WriteLine($"Please Write A Sentence.{Environment.NewLine}");
            string userSentence = Console.ReadLine();
            capitalletterscount = userSentence.ToCharArray().Count(c => char.IsUpper(c));
            Console.WriteLine($"The Number Of Capitals In Your Sentence Is: {capitalletterscount}.");
        }

        private static void showVersionFunction_Chosen()
        {
            Console.WriteLine("Version: 24.1.4.9633 {0}", Environment.NewLine);
        }
    }
}
