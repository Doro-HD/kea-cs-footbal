namespace Football.Round
{
    public class Round
    {
        private string team1;
        private string team2;
        private int team1Score;
        private int team2Score;

        public Round (string team1, string team2, int team1Score, int team2Score)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.team1Score = team1Score;
            this.team2Score = team2Score;
        }
    }
}