using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class ShowDate : IChoiceObserver
    {
        public void DoFunction()
        {
            Console.WriteLine("Today's date is: {0}{1}", DateTime.Now.ToString("d"), Environment.NewLine);
        }
    }
}
