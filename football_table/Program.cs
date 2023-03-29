using Football.File;

namespace Football
{
    public class Program
    {
        public static void Main(String[] args)
        {
            FileAssistant fileAssistant = new FileAssistant();
            List<List<string>> matches = fileAssistant.Read("../../KEA-CS-FOOTBALL/csv files/Rounds");
            List<List<string>> teams = fileAssistant.Read("../../KEA-CS-FOOTBALL/csv files/teams");
            List<Team> teamList = new List<Team>();
            List<Match> matchList = new List<Match>();
            List<Round> roundList = new List<Round>();

            foreach(List<string> t in teams)
            {
                Team team = new Team(t);
                teamList.Add(team);
            }

            foreach(List<string> m in matches)
            {
                var team1 = teamList.Find(t => t.abbr == m[0]);
                var team2 = teamList.Find(t => t.abbr == m[1]);
                
                Match match = new Match(m, team1, team2);
                matchList.Add(match);
            }

        
            for (int i = 0; i < matchList.Count; i += 6)
            {   
                var currentRound = matchList.GetRange(i, 6);
                var round = new Round(currentRound);
                roundList.Add(round);
            }
         
        }
    }
}