using System;
using System.Collections.Generic;
using System.Text;

namespace Ceroes_
{
    internal class Player
    {
        public static Player player1 = new Player(3);
        public static Player player2 = new Player(4);
        public int color;

        public Player(int Color) 
        {
            color = Color;
            Materials Resource = new Materials(0, 0, 0, 0);
           }

       public struct Materials
        {           
            public static List<int> quantity = new List<int>();
            public Materials(int Gold,int Wood,int Stone,int Crystal)
            {
                quantity.Add(Gold);
                quantity.Add(Wood);
                quantity.Add(Stone);
                quantity.Add(Crystal);
            }
            public static void Place()
            {
                Map.mapa.plane[10][10] = 5;
            }
        }
    }
}
