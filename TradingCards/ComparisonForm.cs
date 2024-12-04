using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class ComparisonForm : Form
    {
        private List<Player> players;

        public ComparisonForm(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            BindPlayersToDropdowns();
        }

        private void BindPlayersToDropdowns()
        {
            var playerNames = players.Select(p => p.Name).ToList();
            cmbPlayer1.DataSource = new List<string>(playerNames);
            cmbPlayer2.DataSource = new List<string>(playerNames);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (cmbPlayer1.SelectedIndex == -1 || cmbPlayer2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select two players to compare.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPlayer1.SelectedItem.ToString() == cmbPlayer2.SelectedItem.ToString())
            {
                MessageBox.Show("Please select two different players.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var player1 = players.First(p => p.Name == cmbPlayer1.SelectedItem.ToString());
            var player2 = players.First(p => p.Name == cmbPlayer2.SelectedItem.ToString());

            string result = $"Comparison Result:\n\n" +
                            $"{player1.Name}: {player1.Points} Points, {player1.Assists} Assists, {player1.Rebounds} Rebounds\n" +
                            $"{player2.Name}: {player2.Points} Points, {player2.Assists} Assists, {player2.Rebounds} Rebounds\n\n";

            result += player1.Points > player2.Points
                ? $"{player1.Name} has more points."
                : player2.Points > player1.Points
                    ? $"{player2.Name} has more points."
                    : "Both players have the same number of points.";

            lblComparisonResult.Text = result; // Display the result in the label
        }
    }
}
