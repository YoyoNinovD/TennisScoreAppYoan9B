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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private static Dictionary<string, int> playerWithPoints = new();

        private void listViewRanking_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only open if a row is actually selected
            if (this.listViewRanking.SelectedItems.Count > 0)
            {
                ViewProfileButtonClick();
            }
        }



        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }


        private void FillRankingListView()
        {
            this.listViewRanking.Items.Clear();

            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem rollInRankingListView = new();

                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);

                this.listViewRanking.Items.Add(rollInRankingListView);
            }
        }

        private static Dictionary<string, int> playersWithPoints = new();


        private void FillLatestGamesListView()
        {
            this.listViewLatestGame.Items.Clear();

            foreach (var game in gamess.Reverse())
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLatestGameListView = new ListViewItem();

            rollInLatestGameListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLatestGameListView.SubItems.Add(secondPlayer.Item1);
            rollInLatestGameListView.SubItems.Add(winner);
            rollInLatestGameListView.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item2}");
            this.listViewLatestGame.Items.Add(rollInLatestGameListView);
        }

        private string GetWinner((string, int) firstPlayer, (string, int) SecondPlayer)
        {
            if (firstPlayer.Item2 > SecondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 < SecondPlayer.Item2)
            {
                return SecondPlayer.Item1;
            }

            return "Draw";
        }

        private static Dictionary<(string, int), List<(string, int)>> gamess = new()
        {
            {("G. Dimitrov", 3), new List<(string, int)>{("R. Nadal", 2)} },
            {("R. Nadal", 3), new List<(string, int)>{("R. Federer", 1)} },
            {("G. Dimitrov", 2), new List<(string, int)>{("R. Federer", 3)} }
        };


        private void AddNewGameButtonClick(object sender, EventArgs e)
        {
            using (Form2 newGameForm = new Form2())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }

        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGameData(firstPlayer, secondPlayer);

            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);

            FillRankingListView();
            FillLatestGamesListView();
        }
        private void FillGameData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (gamess.ContainsKey(firstPlayer))
            {
                gamess[firstPlayer].Add(secondPlayer);
            }
            else if (gamess.ContainsKey(secondPlayer))
            {
                gamess[secondPlayer].Add(firstPlayer);
            }
            else
            {
                gamess.Add(firstPlayer, new List<(string, int)> { secondPlayer });
            }
        }

        private void FillPlayerWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints[player.Item1] = player.Item2;
            }
        }

        private void ViewProfileButtonClick()
        {
            ListViewItem selectedRow = this.listViewRanking.SelectedItems[0];
            ListViewSubItem playerNameCell = selectedRow.SubItems[0];
            string playerName = playerNameCell.Text;

            using (Form3 playerInfoForm = new Form3
                (playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames
             (string playerName)
            => gamess.Where(x => x.Key.Item1 == playerName
            || x.Value.Any(y => y.Item1 == playerName))
            .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName
            || x.Key.Item1 == playerName).ToList());

        private void listViewLatestGame_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
