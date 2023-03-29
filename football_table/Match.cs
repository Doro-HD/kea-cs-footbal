namespace Football
{
    public class Match
    {
        public Team team1 { get; set; }
        public Team team2 { get; set; }
        public int team1Score { get; set; }
        public int team2Score { get; set; }

        public Match (List<string> Matches, Team team1, Team team2)
        {
            this.team1 = team1;           
            this.team2 = team2;           
            this.team1Score = Int16.Parse(Matches[2]);
            this.team2Score = Int16.Parse(Matches[3]);
        }

        public int GetTeam2Score()
        {
            return this.team2.points;
        }    

        public int GetTeam1Score()
        {
            return this.team1.points;
        } 


        
        
    }
}
