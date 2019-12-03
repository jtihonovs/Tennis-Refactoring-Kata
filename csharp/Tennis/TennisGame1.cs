using System;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (m_score1 == m_score2)
            {
                score = m_score1 < 3 ? this.getScoreName(m_score1) + "-All" : "Deuce";
            }
            else if (m_score1 >= 4 || m_score2 >= 4)
            {
                string ahead = (m_score1 > m_score2) ? "player1" : "player2";
                score = Math.Abs(m_score1 - m_score2) == 1 ? "Advantage " + ahead : "Win for " + ahead;
            }
            else
            {
                score = this.getScoreName(m_score1) + "-" + this.getScoreName(m_score2);
            }
            return score;
        }

        public string getScoreName(int tempScore)
        {
            switch (tempScore)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                default:
                    return "Forty";
            }
        }
    }
}

