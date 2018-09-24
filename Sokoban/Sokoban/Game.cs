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

        public Game()
        {
            Player = new Player();
            parser = new Parser();
            _allDesFields = new List<DestinationField>();
            HasWon = false;
            _outputView = new OutputView();
            _inputView = new InputView(this);
            _outputView.StartMessage();
            parser.CreateMaze(_inputView.ChooseMaze() , Player);
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
                
                _outputView.StandardScreen(parser.firstField2, parser.levelWidth, parser.levelHeight);
            }

            _outputView.PlayerHasWonScreen();
            ResetGame();
            _outputView.StartMessage();
            _inputView.ChooseMaze();
        }

        public void StartOver()
        {
            Console.Clear();
            _outputView.StartMessage();
            parser.CreateMaze(_inputView.ChooseMaze(), Player);
            Play();
        }

        public void ResetGame()
        {
            //naar beginpunt
        }
    }
}