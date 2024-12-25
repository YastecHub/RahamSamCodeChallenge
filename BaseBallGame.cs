namespace RahamSamCodeChallenge
{
    public class BaseBallGame
    {
        public int GamePoints(string[] ops)
        {
            var record = new List<int>();

            foreach (var op in ops)
            {
                if (op == "C")
                {
                    //Invalidate the previous score, removing it from the record.
                    // It is guaranteed there will always be a previous score.
                    if (record.Count > 0 && record.Count > 2)
                    {
                        record.RemoveAt(record.Count - 1);
                    }
                }
                else if (op == "D")
                {
                    //Record a new score that is double the previous score.
                    // It is guaranteed there will always be a previous score.
                    record.Add(record[record.Count - 1] * 2);
                }
                else if(op == "+")
                {
                    //Record a new score that is the sum of the previous two scores.
                    // It is guaranteed there will always be two previous scores.
                    int sumOfLastTwo = record[record.Count - 1] + record[record.Count - 2];
                    record.Add(sumOfLastTwo);
                }
                else
                {
                    ///Return the sum of all the scores on the record.
                    int score = int.Parse(op);
                    record.Add(score);
                }
            }

            int totalScore = 0;
            foreach (var score in record)
            {
              totalScore += score;
            }
            return totalScore;
        }
    }
}