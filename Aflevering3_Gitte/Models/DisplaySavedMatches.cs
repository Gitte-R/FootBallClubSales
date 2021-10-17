using System.Collections.Generic;
using System.Windows.Controls;

namespace Aflevering3_Gitte.Models
{
    public static class DisplaySavedMatches
    {
        public static void AddMatchToView(List<Match> allMatchesList, DataGrid viewOfMatches)
        {
            viewOfMatches.Items.Clear();
            foreach (Match match in allMatchesList)
            {
                viewOfMatches.Items.Add(match);
            }
        }
    }
}

