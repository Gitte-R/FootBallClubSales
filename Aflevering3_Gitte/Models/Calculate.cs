using System.Globalization;
using System.Windows.Controls;

namespace Aflevering3_Gitte.Models
{
    public class Calculate
    {
        private decimal salesTotal;
        private decimal earningsTotal;

        public string CalculateSales(Match newFootballMatch)
        {
            decimal shopEarnings = newFootballMatch.StoreVisitors * FootballClubStats.SaleFromShopvisitsPercent * FootballClubStats.SaleSportsGoodsAvg;
            decimal salesBeverage = newFootballMatch.TicketsSold * (newFootballMatch.SpectatorsPercentage / 100) * FootballClubStats.SaleBeverageAvg;
            int tvEarnings = newFootballMatch.TVChannels * FootballClubStats.TvRightsPerChannel;
            int subscriptionEarnings = newFootballMatch.GymSubscriptions * FootballClubStats.SubscriptionPrice;
            int ticketEarnings = newFootballMatch.TicketsSold * FootballClubStats.TicketPriceAvg;

            salesTotal = shopEarnings + salesBeverage + tvEarnings + subscriptionEarnings + ticketEarnings;
            newFootballMatch.SalesTotal = salesTotal.ToString("C2", CultureInfo.CurrentCulture);
            return newFootballMatch.SalesTotal;
        }

        public string CalculateEarnings(Match newFootballMatch)
        {
            decimal costTotal = salesTotal * FootballClubStats.TotalCostsPercent;
            earningsTotal = salesTotal - costTotal;
            newFootballMatch.EarningsTotal = earningsTotal.ToString("C2", CultureInfo.CurrentCulture);
            return newFootballMatch.EarningsTotal;
        }
    }
}
