using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Ceroes_
{
    internal class Technical
    {
        static public void CleanBuffer() { while (Console.KeyAvailable) { Console.ReadKey(true); } }
        static public string KeyPress()
        {
            ConsoleKeyInfo press;
            press = Console.ReadKey();
            string key = press.Key.ToString();
            return key;
        }
        
    }
}
