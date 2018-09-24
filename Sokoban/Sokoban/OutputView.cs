using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {
        public void StartMessage()
        {
            Console.WriteLine("┌────────────────────────────────────────────────────┐");
            Console.WriteLine("| Welkom bij Sokoban                                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| betekenis van de symbolen   |   doel van het spel  |");
            Console.WriteLine("|                             |                      |");
            Console.WriteLine("| spatie : outerspace         |   duw met de truck   |");
            Console.WriteLine("|      █ : muur               |   de krat(ten)       |");
            Console.WriteLine("|      · : vloer              |   naar de bestemming |");
            Console.WriteLine("|      O : krat               |                      |");
            Console.WriteLine("|      0 : krat op bestemming |                      |");
            Console.WriteLine("|      x : bestemming         |                      |");
            Console.WriteLine("|      @ : truck              |                      |");
            Console.WriteLine("└────────────────────────────────────────────────────┘");
        }

        public void StandardScreen(Field startingField,int mazeWidth, int mazeLength)
        {
            Console.Clear();
            Console.WriteLine("┌──────────┐");
            Console.WriteLine("| Sokoban  |");
            Console.WriteLine("└──────────┘");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");

            //hier komt dan het doolhof te staan
            PrintMaze(startingField, mazeWidth, mazeLength);

            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("> gebruik pijljestoetsen(s = stop, r = reset)");
        }

        private void PrintMaze(Field startingField,int mazeWidth, int mazeLength)
        {
            String printString = "";
            Field tempField = startingField.LowerField;
            Field[] FirstFields = new Field[mazeLength];
            FirstFields[0]= startingField;
            tempField = startingField;
           // FirstFields[1] =tempField;
            int i = 1;
            while(true)
            {
                if(tempField.LowerField != null)
                {
                    FirstFields[i]=tempField.LowerField;
                    tempField = tempField.LowerField;
                }
                else
                {
                    break;
                }
                i++;
            }
            for (int y = FirstFields.Length -1; y > -1; y--)
            {
                tempField = FirstFields[y ];
                for (int x = 0; x < mazeWidth; x++)
                {if(tempField.Player != null)
                    {
                        printString += "@";
                    }
                   else if (tempField is Wall)
                    {
                        printString += "#";
                    }
                    else if (tempField is DestinationField)
                    {
                        if (tempField.Crate != null || tempField.HasCrate)
                        {
                            printString += "0";
                        }
                        else
                        {
                            printString += "x";
                        }
                    }else if(tempField is EmptyField)
                    {
                        printString += " ";
                    }
                    else if(tempField is Field)
                    { if(tempField.Crate != null || tempField.HasCrate)
                        {
                            printString += "o";
                        }
                        else
                        {
                            printString += ".";
                        }
                        
                    }

                    if (tempField.RightField != null)
                    { 
                        tempField = tempField.RightField;
                    }
                }
                Console.WriteLine(printString);
                printString = "";
                


            }

        }

        public void PlayerHasWonScreen()
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("=== HOERA OPGELOST ===");
            Console.WriteLine("> press key to continue");
            Console.ReadKey();
        }
    }
}