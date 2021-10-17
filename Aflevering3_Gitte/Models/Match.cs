using System;
using System.Windows.Controls;

namespace Aflevering3_Gitte.Models
{
    public class Match
    {
        public int TicketsSold { get; set; } = 0;
        public int TVChannels { get; set; } = 0;
        public int StoreVisitors { get; set; } = 0;
        public int GymSubscriptions { get; set; } = 0;
        public decimal SpectatorsPercentage { get; set; } = 0;
        public string SalesTotal { get; set; }
        public string EarningsTotal { get; set; }
    }
}

