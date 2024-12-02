using System;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Ceroes_
{
    internal class Program
    {
        public static int player = 0;
        public static bool gameLoopRunning = true;
        //public static Map mapa;
        static void TechnicalSetup()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }
        static void GameSetup()
        {
            Object.Initialization();
            
        }
        static void PlayerAction()
        {            
            int moveX = 0, moveY = 0;
            string key = Technical.KeyPress();
            Console.WriteLine(key);

            switch(key) 
            {
                case "W": moveY=-1; break;
                case "D": moveX= 1; break;
                case "S": moveY= 1; break;
                case "A": moveX=-1; break;                    
            }
            if (Map.mapa.IsInside(Object.Hero.list[player].x+moveX,Object.Hero.list[player].y + moveY)&& Map.mapa.SpotEmpty(Object.Hero.list[player].x + moveX, Object.Hero.list[player].y + moveY))
            {
                
                Map.mapa.Move(Object.Hero.list[player].x, Object.Hero.list[player].y, moveX, moveY);
                Object.Hero.list[player].x += moveX;
                Object.Hero.list[player].y += moveY;
            }   
        }
       
        static void GameLoop()
        {
            while(gameLoopRunning)
            {

                Map.mapa.PrintPlane();
                Map.mapa.DrawBox();
                //Console.WriteLine(Hero.Player.x + " " + Hero.Player.y);
                PlayerAction();
                

                Technical.CleanBuffer();
                Thread.Sleep(100);
                Console.Clear();
            }

        }
        
        static void Main(string[] args)
        {
          
            TechnicalSetup();
            GameSetup();
            GameLoop();
      
        }
    }
}
