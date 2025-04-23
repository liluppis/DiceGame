using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{ 
    internal class Player
    {
        // readonly === final 
        // == username can only be set in the constructor
        private readonly string userName;
        private int score;

        // constructor
        public Player(string userName, int score)
        {
            this.userName = userName;
            this.score = score;
        }

        // getters and setters
        public string GetUserName()
        {
            return userName;
        }

        public int GetScore()
        {
            return score;
        }

        public void addScore(int additionalScore)
        {
            score += additionalScore;
        }

        // Override of ToString
        public override string ToString()
        {
            return userName;
        }

    }
}
