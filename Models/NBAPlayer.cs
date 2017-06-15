using System;
namespace tryagain.Models
{
    public class NBAPlayer
    {
        private static string _sport = "Basketball";

        public string Name { get; set; }
        public object PlayerPic { get; set; }
        public int MVPVotes { get; set; }

        public NBAPlayer()
        {
        }
    }
}
