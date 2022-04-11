using System;
using System.Collections.Generic;
using System.Text;

namespace lv3
{
    public class ScoreCalculator
    {
        private int score;

        public ScoreCalculator(int score)
        {
            this.score = score;
        }
        public virtual int LenScore(string word)
        {
            word.ToLower();
            int brojac = 0;
            foreach(char c in word)
            {
                brojac += 1;
            }
            return brojac;
        }
    }
    public class CharScoreCalculator : ScoreCalculator
    {
        private int charScore;

        public CharScoreCalculator(int score,int charScore) : base(score)
        {
            this.charScore = charScore;
        }
        public override int LenScore(string word)
        {
            word.ToLower();
            int brojac1 = 0;
            int brojac2 = 0;
            foreach(char c in word)
            {
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') { brojac1 += 3; }
                else { brojac2 += 2; }
            }
            return  brojac1 + brojac2;
        }
    }
}
