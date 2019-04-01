using System;

namespace BowlingGame
{
    public class Game
    {
        
        private int[] rolls = new int[21];

        private int currentRoll = 0;

        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int GetScore()
        {
            int score = 0;
            int firstInFrame = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(firstInFrame))
                {
                    score += NextTwoBallsForStike(firstInFrame);
                    firstInFrame++;
                }
                else if (isSpare(firstInFrame))
                {
                    score += 10 + NextBallForSpare(firstInFrame);
                    firstInFrame += 2;
                }
                else
                {
                    score += TwoBallsInFrame(firstInFrame);
                    firstInFrame += 2;
                }
            }
            return score;
        }

        private int TwoBallsInFrame(int firstInFrame)
        {
            return rolls[firstInFrame] + rolls[firstInFrame + 1];
        }

        private int NextBallForSpare(int firstInFrame)
        {
            return rolls[firstInFrame + 2];
        }

        private int NextTwoBallsForStike(int firstInFrame)
        {
            return 10 + rolls[firstInFrame + 1] + rolls[firstInFrame + 2];
        }

        private bool IsStrike(int firstInFrame)
        {
            return rolls[firstInFrame] == 10;
        }

        private bool isSpare(int firstInFrame)
        {
            return rolls[firstInFrame] + rolls[firstInFrame + 1] == 10;
        }
    }
}