namespace Football
{
    public class Team
    {
        public string abbr; 
        public string name;
        public string specialRanking;
        public int points;

        public int goalsScored;
        public int goalsLost;
        public int numberOfGamesPlayed;

        public Team (List<string> teams)
        {
            this.abbr = teams[0];
            this.name = teams[1];
            this.specialRanking = teams[2];
            this.points = 0;
            this.goalsScored = 0;
            this.goalsLost = 0;
            this.numberOfGamesPlayed = 0;
        }

        public void TeamWon()
        {
            this.points += 3;
        }

        public void TeamsDraw()
        {
            this.points++;
        }


        
    
    }
}