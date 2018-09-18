using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{ 

    public class Parser
    {
        private int levelWidth;
        private int levelHeight;
        private char[,] charField;
        public char[,] CharField
        {
            get { return charField; }
            set { charField = value; }
        }

        public void createMaze(int level)
        {
            string maze = null;
            switch (level)
            {
                case 1:
                    maze = System.IO.File.ReadAllText(@"D:\Doolhof\Doolhof1.txt");
                    this.levelHeight = 6;
                    this.levelWidth = 9;
                    break;
                case 2:
                    maze = System.IO.File.ReadAllText(@"D:\Doolhof\Doolhof2.txt");
                    break;
                case 3:
                    maze = System.IO.File.ReadAllText(@"D:\Doolhof\Doolhof3.txt");
                    break;
                case 4:
                    maze = System.IO.File.ReadAllText(@"D:\Doolhof\Doolhof4.txt");
                    break;
                default:
                    Console.WriteLine("choose between 1 and 4");
                    break;

            }

            
            Console.WriteLine(maze);
            createCharField(maze);

        }

        private void createCharField(String maze)
        {
           // for(int i = 0; i < maze.Length; i++)
           // {
           //     Console.WriteLine(i+": " + maze.ElementAt(i));
           // }

            char[,] tempArray = new char[levelWidth ,levelHeight];
            for(int y = 0; y< this.levelHeight; y++)
            {
                for (int x = 0; x < levelWidth; x++)
                {
                    tempArray[x, y] = maze.ElementAt((y * levelHeight) + x);
                }
            }


            
            

        }
    }

}