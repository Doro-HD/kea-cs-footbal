namespace Football.League
{
    public class League
    {
        string leagueName;
        int positionsToPromoteToChL;
        int positionstoPromoteToEL;
        int positionsToPromoteToCoL;
        int positionsToPromoteToUpperLeague;
        int positionsToRelegateToLowerLeague; 

        public League(string leagueName, int positionsToPromoteToChL, int positionstoPromoteToEL, int positionsToPromoteToCoL, 
        int positionsToPromoteToUpperLeague, int positionsToRelegateToLowerLeague)
        {
        this.leagueName = leagueName;
        this.positionsToPromoteToChL = positionsToPromoteToChL;
        this.positionstoPromoteToEL = positionstoPromoteToEL;
        this.positionsToPromoteToCoL = positionsToPromoteToCoL;
        this.positionsToPromoteToUpperLeague = positionsToPromoteToUpperLeague;
        this.positionsToRelegateToLowerLeague = positionsToRelegateToLowerLeague;
        }
    }
}