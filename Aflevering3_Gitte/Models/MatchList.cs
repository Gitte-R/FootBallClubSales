using System.Collections.Generic;

namespace Aflevering3_Gitte.Models
{
    public static class MatchList
    {
        public static List<Match> AllMatchesList = new List<Match>();
        public static void SaveMatch(Match newFootballMatch)
        {
            AllMatchesList.Add(newFootballMatch);
        }
    }
}
