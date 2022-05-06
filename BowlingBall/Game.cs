namespace BowlingBall
{
    public class Game
    {
        public int[] Frames = new int[21];
        public int chance = 0;
        public void Throws(int[] frame)
        {
            for (int i = 0; i < frame.Length; i++)
            {
                Roll(frame[i]);
            }
        }
        public void Roll(int pins)
        {
            // Add your logic here. Add classes as needed.
            Frames[chance++] = pins;
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            int score = 0;
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Frames[j] == 10)
                {
                    score += Frames[j] + Frames[j + 1] + Frames[j + 2];
                    j++;
                }
                else if (Frames[j] + Frames[j + 1] == 10)
                {
                    score += Frames[j] + Frames[j + 1] + Frames[j + 2];
                    j = j + 2;
                }
                else
                {
                    score += Frames[j] + Frames[j + 1];
                    j += 2;
                }
            }
            return score;
        }
    }
}
