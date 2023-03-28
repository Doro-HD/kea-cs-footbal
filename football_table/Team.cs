namespace Football.Team
{
    public class Team
    {
        string abbr;
        string name;
        char specialRanking;

        public Team(string abbr, string name, char specialRanking)
        {
            this.abbr = abbr;
            this.name = name;
            this.specialRanking = specialRanking;
        }
    }
}