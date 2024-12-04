using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Ceroes_
{
     class Object
     {
        public int x, y, color;
        public string name;
        

        public static int ReturnColor(int X, int Y)
        {
            int thing = Map.mapa.plane[X][Y];
            if (thing == 1)
            {
                for (int i = 0; i < Hero.list.Count; i++)
                {
                    if (Hero.list[i].x == X && Hero.list[i].y == Y)
                    {
                        return Hero.list[i].color;
                    }
                }
            }
            if (thing == 2||thing==3)
            {

                for (int i = 0; i < Building.list.Count; i++)
                {
                    if (Building.list[i].x == X && Building.list[i].y == Y)
                    {
                        return Building.list[i].color;
                    }
                }
            }
            return 6;
        }
        public static void Initialization()
        {
            Object.Building.Placement();
            Object.PlaneInsertion();
        }
        public static void PlaneInsertion()
        {

            for(int i=0; i<Building.list.Count;i++)
            {
                //if (Building.list[i].name=="Castle")
                Map.mapa.plane[Building.list[i].x][Building.list[i].y] = Building.list[i].id;
            }
            for(int i = 0; i < Hero.list.Count;i++)
            {
                Map.mapa.plane[Hero.list[i].x][Hero.list[i].y] = Hero.list[i].id;
            }
        }

        public class Hero:Object
        {
            public int id = 1;
            public int playerId;
            public static List<Hero> list = new List<Hero> { new Hero("Player",1,1,3,0),new Hero("Oponent", 4, 4, 4,1) };
            //public static Hero Player = new Hero("Player", 1, 1, 3);
            public bool controlled = true;

            

            public Hero(string Name, int X, int Y, int Color,int player)
            {
                name = Name;
                x = X;
                y = Y;
                color = Color;
                playerId = player;
            }
            public int Movement()
            {
                ConsoleKeyInfo press;
                press = Console.ReadKey();
                string key = press.Key.ToString();
                switch (key)
                {
                    case "W": return 0;
                    case "D": return 1;
                    case "S": return 2;
                    case "A": return 3;
                    case "X": return 4; //interact
                }
                return 5;//do nothing
            }
         

        }
        public class Building:Object
        {
            public int id = 2;
      
            public static List<Building> list = new List<Building> {new Object.Building("Castle",5,10,4), new Object.Building("Castle", 10, 5, 3) };
            
            public Building(string Name, int X, int Y, int Color)
            {
                switch(Name)
                {
                    case "Castle": id = 2;break;
                    case "Banner": id = 3;break;
                }
                name = Name;
                x = X;
                y = Y;
                color = Color;
            }
            public static void Placement()
            {
                for(int i  = 0; i < Building.list.Count; i++) 
                {
                    int X= Building.list[i].x;
                    int Y = Building.list[i].y;

                    if (list[i].name == "Castle")
                    {
                        
                        Map.mapa.background[X][Y] = 1;
                        Map.mapa.background[X+1][Y] = 1;
                        Map.mapa.background[X-1][Y] = 1;
                        Map.mapa.background[X - 1][Y-1]= 1;
                        Map.mapa.background[X + 1][Y-1] = 1;


                        Map.mapa.plane[X+1][Y] = 3;
                        Map.mapa.plane[X-1][Y] = 3;
                        Map.mapa.plane[X][Y-1] = 4;

                        list.Add(new Object.Building("Banner", X + 1, Y, list[i].color));
                        
                     
                        list.Add(new Object.Building("Banner", X - 1, Y, list[i].color));
                        
                    }
                }
            }
        }
   
    }
}
