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
            string[] maze = null;
            switch (level)
            {
                case 1:
                    maze = System.IO.File.ReadAllLines(@"D:\Doolhof\Doolhof1.txt");
                    break;
                case 2:
                    maze = System.IO.File.ReadAllLines(@"D:\Doolhof\Doolhof2.txt");
                    break;
                case 3:
                    maze = System.IO.File.ReadAllLines(@"D:\Doolhof\Doolhof3.txt");
                    break;
                case 4:
                    maze = System.IO.File.ReadAllLines(@"D:\Doolhof\Doolhof4.txt");
                    break;
                default:
                    Console.WriteLine("choose between 1 and 4");
                    break;

            }
            Console.WriteLine(maze[0]);
            Console.WriteLine(maze[1]);
            Console.WriteLine(maze[2]);
            Console.WriteLine(maze[3]);
            Console.WriteLine(maze[4]);
            Console.WriteLine(maze[5]);


            char[,] charArray = CreateCharField(maze);
            CreateFields(charArray);

        }

        private void CreateFields(char[,] charArray)
        {
            //Create 2d array with fields
            Field[,] f = new Field[levelWidth, levelHeight];
            for (int x = 0; x < levelWidth; x++)
            {
                for (int y = levelHeight - 1; y>0; y--)
                {
                    char c = charArray[x, y];
                    switch (c)
                    {
                        case '#':
                            f[x, y] = new Wall();
                            break;
                        case '.':
                            f[x, y] = new Field();
                            break;
                        case 'o':
                            f[x, y] = new Field { Crate = new Crate() };
                            break;
                        case 'x':
                            f[x, y] = new DestinationField();
                            break;
                        case '@':
                            f[x, y] = new Field { Player = new Player() };
                            break;
                    }
                }
            }
            //link the fields with each other
            for (int x = 0; x < levelWidth; x++)
            {
                for (int y = levelHeight - 1; y > 0; y--)
                {
                    if(y != levelHeight)
                    {

                    }

                }
            }
        }

        private char[,] CreateCharField(String[] maze)
        {
            this.levelHeight = maze.Length;
            this.levelWidth = maze[0].Length;
            for(int i = 0; i< maze.Length; i++)
            {
                if(levelWidth < maze[i].Length)
                {
                    levelWidth = maze[i].Length;
                }
            }
            char[,] tempArray = new char[levelWidth,maze.Length];
            for(int x = 0; x < maze.Length; x++)
            {
                for (int y = 0; y<maze[x].Length; y++)
                {
                    tempArray[y, x] = maze[x].ElementAt(y);
                }
            }
         

            //Array van strings
            // en dan splitsen per rij van de 2d array
            // for(int i = 0; i < maze.Length; i++)
            // {
            //     Console.WriteLine(i+": " + maze.ElementAt(i));
            // }

            //char[,] tempArray = new char[levelWidth + 1 ,levelHeight +1];
            //for(int y = 0; y< levelHeight + 1; y++)
            //{
            //    for (int x = 0; x < levelWidth ; x++)
            //    {
            //        tempArray[x, y] = maze.ElementAt((y * levelWidth) + x);
            //    }
            //}

            //for (int y = 0; y < this.levelHeight; y++)
            //{
            //    for (int x = 0; x < levelWidth; x++)
            //    {
            //        if(x == levelWidth - 1)
            //        {
            //            Console.WriteLine("");
            //        }
            //        Console.Write(tempArray[x, y].ToString());
            //    }
            //}

            int rowLength = tempArray.GetLength(0);
            int colLength = tempArray.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", tempArray[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.WriteLine();
            return tempArray;
        }


    }

}