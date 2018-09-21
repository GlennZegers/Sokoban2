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
        public Maze Maze
        {
            get => default(Maze);
            set
            {
            }
        }

        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        private OutputView _outputView;
        private InputView _inputView;

        public Game()
        {
            _allDesFields = new List<DestinationField>();
            HasWon = false;
            _outputView = new OutputView();
            _inputView = new InputView();
        }

        public bool CheckIfWon()
        {
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
            _outputView.StandardScreen();
            //hier is dus al een doolhof gekozen
            while (!HasWon)
            {
                _inputView.MakeAMove();
                CheckIfWon();
                _outputView.StandardScreen();
            }

            _outputView.PlayerHasWonScreen();
            ResetGame();
            _outputView.StartMessage();
            _inputView.ChooseMaze();
        }

        public void ResetGame()
        {
            //naar beginpunt
        }
    }
}