using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IChoiceObserver
    {
        public void DoFunction()
        {
            int capitalletterscount = 0;
            Console.WriteLine($"Please Write A Sentence.{Environment.NewLine}");
            string userSentence = Console.ReadLine();
            capitalletterscount = userSentence.ToCharArray().Count(c => char.IsUpper(c));
            Console.WriteLine($"The Number Of Capitals In Your Sentence Is: {capitalletterscount}.");
        }
    }
}
