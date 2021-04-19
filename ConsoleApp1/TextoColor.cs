using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TextoColor
    {
        string color;
        public void EscribeTexto(string s)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(s);
        }
    }
}
