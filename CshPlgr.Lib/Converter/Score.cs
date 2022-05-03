namespace CshPlgr.Lib.Converter
{
    internal class Score
    {
        internal static int CalculateScore(string text)
        {
            return AddScoreIfDialesis(text,
                    AddScoreIfBreath(text,
                    AddScoreIfAccent(text,
                    AddScoreIfIotaSubscriptum(text))));
        }

        private static int AddScoreIfDialesis(string text, int score = 0)
        {
            if (text.Contains("\""))
            {
                return 64 + score;
            }
            return score;
        }

        private static int AddScoreIfBreath(string text, int score = 0)
        {
            if (text.Contains("<"))
            {
                return 16 + score;
            }
            if (text.Contains(">"))
            {
                return 32 + score;
            }
            return score;
        }

        private static int AddScoreIfAccent(string text, int score = 0)
        {
            if (text.Contains("'"))
            {
                return  4 + score;
            }
            if (text.Contains("`"))
            {
                return  8 + score;
            }
            if (text.Contains("~"))
            {
                return 12 + score;
            }
            return score;
        }

        private static int AddScoreIfIotaSubscriptum(string text, int score = 0)
        {
            if (text.Contains("|"))
            {
                return 1 + score;
            }
            return score;
        }
    }
}
