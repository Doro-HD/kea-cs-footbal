namespace Football
{
    public class Team
    {
        public string abbr {get; set;}
        public string name {get; set;}
        public string specialRanking {get; set;}
        public int points {get; set;}

        public int goalsScored {get; set;}
        public int goalsLost {get; set;}
        public int numberOfGamesPlayed {get; set;}
        public int numberOfGamesWon {get; set;}
        public int numberOfGamesDrawn {get; set;}
        public int numberOfGamesLost {get; set;}

        public int goalDifference => goalsLost - goalsScored; 

        public Team (List<string> teams)
        {
            this.abbr = teams[0];
            this.name = teams[1];
            this.specialRanking = teams[2];
            this.points = 0;
            this.goalsScored = 0;
            this.goalsLost = 0;
            this.numberOfGamesPlayed = 0;
            this.numberOfGamesWon = 0;
            this.numberOfGamesDrawn = 0;
            this.numberOfGamesLost = 0;
        }

        public void TeamWon()
        {
            this.points += 3;
            this.numberOfGamesWon += 1;
        }

        public void TeamsDraw()
        {
            this.points++;
            this.numberOfGamesDrawn += 1;
        }


        
    
    }
}