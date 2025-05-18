using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Score_App
{
    public partial class Form3 : Form
    {

        private string playerName;
        private Dictionary<(string, int), List<(string, int)>> games;
        private (string, int) currentPlayer = new();
        private (string, int) competitor = new();


        public Form3(string playerName, Dictionary<(string, int), List<(string, int)>> games)
        {
            InitializeComponent();
            this.playerName = playerName;
            this.games = games;
            this.PlayerName.Text = playerName;
            FillVictoriesAndLossesListViews();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void PlayerInfoForm(string playerName,
            Dictionary<(string, int), List<(string, int)>> games)
        {
            InitializeComponent();


            this.games = games;
            this.playerName = playerName;

            this.PlayerName.Text = playerName;

            FillVictoriesAndLossesListViews();


        }

        private void FillVictoriesAndLossesListViews()
        {
            ClearListView();

            foreach (var game in games)
            {
                string firstPlayeName = game.Key.Item1;
                int firstPlayerPoints = game.Key.Item2;
                foreach (var item in game.Value)
                {
                    string secondPlayerName = item.Item1;
                    int secondPlayerPoints = item.Item2;

                    (this.currentPlayer, this.competitor) =
                     GetCurrentPlayerAndCompetitor((firstPlayeName, firstPlayerPoints),
                    (secondPlayerName, secondPlayerPoints));
                    UpdateListView();
                }
            }
        }

        private void ClearListView()
        {
            this.listViewDraw.Items.Clear();
            this.listViewLosses.Items.Clear();
            this.listViewVictories.Items.Clear();

        }

        private ((string, int), (string, int)) GetCurrentPlayerAndCompetitor
            ((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item1 == playerName)
            {
                return (firstPlayer, secondPlayer);
            }
            return (secondPlayer, firstPlayer);
        }

        private void UpdateListView()
        {
            string competitorName = competitor.Item1;
            int currentPlayerPoints = currentPlayer.Item2;
            int competitorPoints = competitor.Item2;
            string score = $"{currentPlayerPoints} - {competitorPoints}";
            ListView currentListView = GetCurrentListView(currentPlayerPoints, competitorPoints);
            AddDataToListView(competitorName, score, currentListView);

        }

        private ListView GetCurrentListView(int currentPlayerPoints, int competitorPoints)
        {
            if (currentPlayerPoints > competitorPoints)
                return this.listViewVictories;
            else if (currentPlayerPoints < competitorPoints)
                return this.listViewLosses;
            else
                return this.listViewDraw;
        }

        private void AddDataToListView(string competitor, string score, ListView listView)
        {
            var listViewItem = new ListViewItem(competitor);
            listViewItem.SubItems.Add(score);
            listView.Items.Add(listViewItem);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
