using Sokoban.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Game
    {
        public Parser parser { get; set; }
        public Player Player { get; set; }
        public Employee Employee { get; set; }
        private OutputView _outputView;
        private InputView _inputView;
        public Field FirstField { get; set; }
        public int Level { get; set; } 
        public int WinCounter { get; set; }
        public int DesFieldCounter { get; set; }

        public Game()
        {
            DesFieldCounter = 0;
            WinCounter = 0;
            Player = new Player();
            Employee = new Employee();
            parser = new Parser();
            _outputView = new OutputView();
            _inputView = new InputView(this);
            _outputView.StartMessage();
            Level = _inputView.ChooseMaze();
            parser.CreateMaze(Level , Player, this, Employee);
            FirstField = parser.firstField2;
            Play();
        }

        public bool CheckIfWon()
        {
            return DesFieldCounter == WinCounter;

        }

        public void Play()
        {
            while (!CheckIfWon())
            {
                _inputView.MakeAMove();
                _outputView.StandardScreen(FirstField, parser.levelWidth, parser.levelHeight);
                Console.WriteLine(DesFieldCounter + "   " + WinCounter);
            }
            _outputView.PlayerHasWonScreen();
            StartOver();
            _outputView.StartMessage();
            _inputView.ChooseMaze();
        }

        public void StartOver()
        {
            Console.Clear();
            DesFieldCounter = 0;
            WinCounter = 0;
            _outputView.StartMessage();
            Player = new Player();
            parser = new Parser();
            Level = _inputView.ChooseMaze();
            parser.CreateMaze(Level, Player, this, Employee);
            FirstField = parser.firstField2;
            Play();
        }

        public void ResetGame()
        {
            Console.Clear();
            DesFieldCounter = 0;
            WinCounter = 0;
            Player = new Player();
            parser = new Parser();
            parser.CreateMaze(Level, Player, this, Employee);
            FirstField = parser.firstField2;
            Play();
        }
    }
}