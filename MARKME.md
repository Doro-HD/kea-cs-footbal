# Null handling and exceptions
At this stage in the program the team can possibly be null so we added a try catch block to prevent a null pointer exception.

```c#
try
{
	match.team1.TeamWon();
	match.team2.numberOfGamesLost += 1;
} catch (Exception e) {
	Console.WriteLine("No no, no team here. " + e);
}
```

# String interpolation
This is where we create the table for the console.

```c#
Console.WriteLine($"{i, -2} | {t.abbr,-3} | {t.name,-25} | {t.specialRanking,-2} | {t.numberOfGamesPlayed,-2} | {t.numberOfGamesWon,-2} |"
                + $" {t.numberOfGamesDrawn,-2} | {t.numberOfGamesLost,-2} | {t.goalsScored,-2} | {t.goalsLost,-2} | {t.goalDifference,-3} | {t.points, -2} | {t.streak}");
```

# classes, strucs and enums
Classes: Match, Round, Team and file.
enums: SpecialRanking

# Properties and attributes
In this exapmle from the Match class, we have 4 attributes, that each have get and set properties.

```c#
public Team team1 { get; set; }
public Team team2 { get; set; }
public int team1Score { get; set; }
public int team2Score { get; set; }
```

# Arrays and collections
In the below example we return a list of list that contains strings, each list represents a row in the csv files used in the assignment.

```c#
public List<List<string>> Read(string dirPath)
{
	var lines = new List<List<string>>();
	string[] filePaths = Directory.GetFiles(dirPath, "*.csv", SearchOption.AllDirectories);

	foreach (string path in filePaths)
	{
		using (var reader = new StreamReader(path))
		{
			reader.ReadLine();
			while (!reader.EndOfStream)
			{
				var line = reader.ReadLine();
				var columns = line.Split(',');
				var columnList = new List<string>(columns);
				lines.Add(columnList);
			}
		}
	}
	
	return lines;
}
```

# Ref
When calculating if a team has a streak we used ref so we could reuse a method instead of having redundent code.

```c#
public void winStreak(List<Round> rounds){
	int wins = 0;
	int draws = 0;
	int losses = 0;

	for (int i = 0; i < rounds.Count; i++){
		var m = rounds[i].matches;
		foreach (Match match in m){
			var homeTeam = match.team1.abbr;
			var otherTeam = match.team2.abbr;

			if (homeTeam == this.abbr) {
				getWin(match.team1Score, match.team2Score, ref wins, ref draws, ref losses);
			} 
			else if (otherTeam == this.abbr)
			{
				getWin(match.team2Score, match.team1Score, ref wins, ref draws, ref losses);
			}
		}
	}

	if (wins > draws && wins > losses)
	{
		this.streak = "W" + wins;
	}
	else if (draws > wins && draws > losses)
	{
		this.streak = "D" + draws;

	}
	else if (losses > wins && losses > draws)
	{
		this.streak = "L" + losses;
	}
	else 
	{
		this.streak = "-";
	}
}

public void getWin(int thisTeamScore, int otherTeamScore, ref int wins, ref int draws, ref int losses){
	if(thisTeamScore < otherTeamScore){
		losses++;
	}
	else if (thisTeamScore == otherTeamScore)
	{
		draws++;
	}
	else
	{
		wins++;
	}
}
```