namespace Football
{
    public class Round
    {
        public Match[] matches = new Match[6];
        Dictionary<string, Team> referenceDict;

        public Round (List<Match> matches)
        {
            this.referenceDict = new Dictionary<string, Team>();
            for (int i = 0; i < 6; i++)
            {
                this.matches[i] = matches[i];
                
                var team1 = matches[i].team1;
                var team2 = matches[i].team2;

                this.referenceDict.Add(team1.abbr, team1);
                this.referenceDict.Add(team2.abbr, team2);
            }
        }

        public void Fight()
        {
            foreach (Match match in this.matches)
            {
                
                if (match.GetTeam1Score() == match.GetTeam2Score())
                {
                    try
                    {
                        match.team1.TeamsDraw();
                        match.team2.TeamsDraw();
                    } catch (Exception e) {
                        Console.WriteLine("No no, no team here. " + e);
                    }
                } 
                else if (match.GetTeam1Score() > match.GetTeam2Score())
                {
                     try
                    {
                        match.team1.TeamWon();
                    } catch (Exception e) {
                        Console.WriteLine("No no, no team here. " + e);
                    }
                }
                else if (match.GetTeam1Score() < match.GetTeam2Score())
                {
                    try
                    {
                        match.team2.TeamWon();
                    } catch (Exception e) {
                        Console.WriteLine("No no, no team here. " + e);
                    }
                }

                match.team1.goalsScored += match.GetTeam1Score();
                match.team2.goalsScored += match.GetTeam2Score();
                match.team1.goalsLost += match.GetTeam2Score();
                match.team2.goalsLost += match.GetTeam1Score();
                match.team1.numberOfGamesPlayed++;
                match.team2.numberOfGamesPlayed++;

            }
        }

    }
}