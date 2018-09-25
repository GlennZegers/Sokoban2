using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Game
    {
        private List<DestinationField> _allDesFields;
        public bool HasWon { get; set; }
        public Parser parser { get; set; }
        public Player Player { get; set; }
        private OutputView _outputView;
        private InputView _inputView;
        public Field FirstField { get; set; }
        public int Level { get; set; } 

        public Game()
        {
            Player = new Player();
            parser = new Parser();
            _allDesFields = new List<DestinationField>();
            HasWon = false;
            _outputView = new OutputView();
            _inputView = new InputView(this);
            _outputView.StartMessage();
            Level = _inputView.ChooseMaze();
            parser.CreateMaze(Level , Player);
            FirstField = parser.firstField2;
            Play();
        }

        public bool CheckIfWon()
        {
            _allDesFields = parser.destFields;
            for (int i = 0; i < _allDesFields.Count; i++)
            {
                if (_allDesFields[i].HasCrate == false)
                {
                    return false;
                }
            }

            HasWon = true;
            return true;

        }

        public void Play()
        {
          
            HasWon = false;
            while (!HasWon)
            {
                _inputView.MakeAMove();
               
                CheckIfWon();
                
                _outputView.StandardScreen(FirstField, parser.levelWidth, parser.levelHeight);
            }

            _outputView.PlayerHasWonScreen();
            StartOver();
            _outputView.StartMessage();
            _inputView.ChooseMaze();
        }

        public void StartOver()
        {
            Console.Clear();
            _outputView.StartMessage();
            Player = new Player();
            parser = new Parser();
            Level = _inputView.ChooseMaze();
            parser.CreateMaze(Level, Player);
            FirstField = parser.firstField2;
            Play();
        }

        public void ResetGame()
        {
            Console.Clear();
            Player = new Player();
            parser = new Parser();
            parser.CreateMaze(Level, Player);
            FirstField = parser.firstField2;
            Play();
        }
    }
}