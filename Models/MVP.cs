﻿using System;
namespace tryagain.Models
{
    public class MVP : NBAPlayer
    {
        public string SeasonHighlights { get; set; }
        public string[] GamesAgainstOthers { get; set; }
       
        public MVP() : base()
        {
            
        }
    }
}
