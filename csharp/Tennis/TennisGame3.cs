using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int p2;
        private int p1;
        private string p1N;
        private string p2N;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.p1N = player1Name;
            this.p2N = player2Name;
        }

        public string GetScore()
        {
            string s;
            if (this.checkIfNotMatchPoint())
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                s = p[p1];
                return this.checkIfEqual() ? s + "-All" : s + "-" + p[p2];
            }
            else
            {
                if (this.checkIfEqual())
                    return "Deuce";
                s = p1 > p2 ? p1N : p2N;
                return (Math.Abs(p1 - p2) == 1) ? "Advantage " + s : "Win for " + s;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this.p1 += 1;
            else
                this.p2 += 1;
        }
        
        public bool checkIfNotMatchPoint()
        {
            return (p1 < 4 && p2 < 4) && (p1 + p2 < 6);
        }

        public bool checkIfEqual()
        {
            return p1 == p2;
        }
    }
}

