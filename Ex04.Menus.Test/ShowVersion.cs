using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IChoiceObserver
    {
        public void DoFunction()
        {
            Console.WriteLine("Version: 24.1.4.9633 {0}", Environment.NewLine);
        }
    }
}
