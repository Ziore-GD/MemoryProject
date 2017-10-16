﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MemoryGame
{
    class Score
    {
        public Panel ScorePanel;
        public Label NameLabel;
        public Label SetsLabel;

        public string Name = "";
        public int Sets = 0;

        public Score(Panel scorePanel, Label nameLabel, Label setsLabel, string name, int sets)
        {
            ScorePanel = scorePanel;
            NameLabel = nameLabel;
            SetsLabel = setsLabel;
            Name = name;
            Sets = sets;
                        
            ScorePanel.Controls.Add(NameLabel);
            ScorePanel.Controls.Add(SetsLabel);
        }
    }
}