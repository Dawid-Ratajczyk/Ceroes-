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
        static public int Flip(int i)
        {
            if (i == 0) return 1;
            else return 0;
        }
        public class Select
        {
            int index;
            int count;
            
            public Select(List<string> Lines)
            {
                index = 0;
                count = Lines.Count;
            }
            public int Choice()
            {
                
                while(true)
                {

                }
            }


        }
        
    }
}
