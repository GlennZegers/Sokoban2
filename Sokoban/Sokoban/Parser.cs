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
        public Field firstField2 { get; set; }
        private Boolean first = true;//MOET OOOOOK WEG
        public char[,] CharField
        {
            get { return charField; }
            set { charField = value; }
        }
        public void print()//moet weg
        {
            OutputView p = new OutputView();
            p.StandardScreen(firstField2, levelWidth, levelHeight);
        }
        public void CreateMaze(int level)
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
            char[,] charArray = CreateCharField(maze);
            CreateFields(charArray);
            print();

        }

        private void CreateFields(char[,] charArray)
        {
            List<Field> fs = new List<Field>();
            //Create 2d array with fields
            Field[,] f = new Field[levelWidth, levelHeight];
            
            for (int x = 0; x < levelWidth; x++)
            {
                for (int y = levelHeight - 1; y>- 1; y--)
                {
                    char c = charArray[x, y];
                    switch (c)
                    {
                        case '#':
                            f[x, y] = new Wall();
                            fs.Add(f[x, y]);
                            
                            break;
                        case '.':
                            f[x, y] = new Field();
                            fs.Add(f[x, y]);
                            break;
                        case 'o':
                            f[x, y] = new Field { Crate = new Crate() };
                            fs.Add(f[x, y]);
                            break;
                        case 'x':
                            f[x, y] = new DestinationField();
                            fs.Add(f[x, y]);
                            break;
                        case '@':
                            
                            f[x, y] = new Field { Player = new Player() };
                            fs.Add(f[x, y]);
                            break;
                        case ' ':
                            f[x, y] = new EmptyField();
                            fs.Add(f[x, y]);
                            break;
                    }
                }
            }
            //link the fields with each other
            
            for (int x = 0; x < levelWidth; x++)
            {
                for (int y = levelHeight - 1; y > 0; y--)
                {
                    if (x == 0 && first)
                    {
                        firstField2 = f[x, y];
                        first = false;
                        
                    }
                    if(y != levelHeight -1)
                    {
                        f[x, y].UpperField = f[x, y + 1];
                    }
                    if(y != 0)
                    {
                        f[x, y].LowerField = f[x, y - 1];
                    }
                    if(x != 0)
                    {
                        f[x, y].LeftField = f[x - 1, y];
                    }
                    if(x != levelWidth - 1)
                    {
                        f[x, y].RightField = f[x + 1, y];
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
            //for (int i = 0; i < tempArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tempArray.GetLength(1); j++)
            //    {
            //        Console.Write(tempArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            return tempArray;
        }


    }

}