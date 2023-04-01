namespace Football
{
    public class Round
    {
        public Match[] matches = new Match[6];

        public Round (List<Match> matches)
        {
            for (int i = 0; i < 6; i++)
            {
                this.matches[i] = matches[i];
                
                var team1 = matches[i].team1;
                var team2 = matches[i].team2;
            }
        }

        public void Fight()
        {
            foreach (Match match in this.matches)
            {
                if (match.team2Score > match.team1Score)
                {
                     try
                    {
                        match.team1.TeamWon();
                        match.team2.numberOfGamesLost += 1;
                    } catch (Exception e) {
                        Console.WriteLine("No no, no team here. " + e);
                    }
                }
                else if (match.team1Score < match.team2Score)
                {
                    try
                    {
                        match.team2.TeamWon();
                        match.team1.numberOfGamesLost += 1;
                    } catch (Exception e) {
                        Console.WriteLine("No no, no team here. " + e);
                    }
                } else 
                {
                    try
                    {
                        match.team1.TeamsDraw();
                        match.team2.TeamsDraw();
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