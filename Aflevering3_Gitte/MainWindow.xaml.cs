using Aflevering3_Gitte.Models;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;

namespace Aflevering3_Gitte
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Match tempMatch;
        
        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Match NewFootballMatch = new Match();
            tempMatch = NewFootballMatch;

            if (int.TryParse(TxtTicketsSold.Text, out int ticketsSold))
            {
                NewFootballMatch.TicketsSold = ticketsSold;
            }
            if (int.TryParse(TxtTVChannels.Text, out int tvChannels))
            {
                NewFootballMatch.TVChannels = tvChannels;
            }
            if (int.TryParse(TxtStoreVisitors.Text, out int storeVisitors))
            {
                NewFootballMatch.StoreVisitors = storeVisitors;
            }
            if (int.TryParse(TxtGymSubscriptions.Text, out int gymSubscriptions))
            {
                NewFootballMatch.GymSubscriptions = gymSubscriptions;
            }
            if (decimal.TryParse(TxtSpectatorsPercentage.Text, out decimal spectatorsPercentage))
            {
                NewFootballMatch.SpectatorsPercentage = spectatorsPercentage;
            }

            Calculate NewCalculation = new Calculate();
            TxtSalesTotal.Text = NewCalculation.CalculateSales(NewFootballMatch);
            TxtEarningsTotal.Text = NewCalculation.CalculateEarnings(NewFootballMatch);
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (tempMatch is not null)
            {
                MatchList.SaveMatch(tempMatch);
                DisplaySavedMatches.AddMatchToView(MatchList.AllMatchesList, DataGridViewOfMatches);

                TxtTicketsSold.Text = string.Empty;
                TxtTVChannels.Text = string.Empty;
                TxtStoreVisitors.Text = string.Empty;
                TxtGymSubscriptions.Text = string.Empty;
                TxtSpectatorsPercentage.Text = string.Empty;
                TxtSalesTotal.Text = string.Empty;
                TxtEarningsTotal.Text = string.Empty;
                tempMatch = null;
            }
        }
    }
}
