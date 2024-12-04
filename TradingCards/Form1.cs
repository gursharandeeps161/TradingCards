using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> players; // List to store player data
        private Dictionary<string, Color> teamColors; // Team color mapping

        public Form1()
        {
            InitializeComponent();
            teamColors = InitializeTeamColors(); // Initialize team colors
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlayers();      // Load initial player data
            BindPlayerList();   // Bind player names to the ListBox
        }

        /// <summary>
        /// Loads the initial set of players into the list.
        /// </summary>
        private void LoadPlayers()
        {
            players = new List<Player>
            {
                new Player { Name = "Virat Kohli", Team = "RCB", Photo = "viratkohli.jpeg", Points = 95, Assists = 15, Rebounds = 12, Matches = 250 },
                new Player { Name = "Rohit Sharma", Team = "MI", Photo = "rohitsharma.jpeg", Points = 85, Assists = 10, Rebounds = 8, Matches = 240 },
                new Player { Name = "MS Dhoni", Team = "CSK", Photo = "msdhoni.jpeg", Points = 80, Assists = 20, Rebounds = 10, Matches = 220 },
                new Player { Name = "KL Rahul", Team = "LSG", Photo = "klrahul.jpeg", Points = 88, Assists = 14, Rebounds = 11, Matches = 150 },
                new Player { Name = "Jasprit Bumrah", Team = "MI", Photo = "jaspritbumrah.jpeg", Points = 70, Assists = 18, Rebounds = 15, Matches = 130 },
                new Player { Name = "Hardik Pandya", Team = "RCB", Photo = "hardikpandya.jpeg", Points = 78, Assists = 12, Rebounds = 9, Matches = 180 },
                new Player { Name = "Shikhar Dhawan", Team = "CSK", Photo = "shikhardhawan.jpeg", Points = 81, Assists = 13, Rebounds = 11, Matches = 200 },
                new Player { Name = "Ravindra Jadeja", Team = "MI", Photo = "ravindrajadeja.jpeg", Points = 68, Assists = 17, Rebounds = 16, Matches = 210 },
                new Player { Name = "Yuzvendra Chahal", Team = "CSK", Photo = "yuzvendrachahal.jpeg", Points = 72, Assists = 15, Rebounds = 14, Matches = 140 },
                new Player { Name = "Rishabh Pant", Team = "RCB", Photo = "rishabhpant.jpeg", Points = 90, Assists = 12, Rebounds = 10, Matches = 190 }

            };
        }

        /// <summary>
        /// Binds the player names to the ListBox.
        /// </summary>
        private void BindPlayerList()
        {
            lstPlayers.DataSource = null; // Reset data source
            lstPlayers.DataSource = players.Select(p => p.Name).ToList(); // Bind names to ListBox
        }

        /// <summary>
        /// Handles the selection of a player in the ListBox.
        /// Updates the card view with the selected player's details.
        /// </summary>
        // private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
         //{
           //  if (lstPlayers.SelectedIndex == -1) return;
           //
             //var selectedPlayer = players.FirstOrDefault(p => p.Name == lstPlayers.SelectedItem.ToString());
         //    if (selectedPlayer == null) return;
         //
           //  lblName.Text = $"Name: {selectedPlayer.Name}";
        //     lblTeam.Text = $"Team: {selectedPlayer.Team}";
          //   lblStats.Text = $"Points: {selectedPlayer.Points}\n" +
            //                 $"Assists: {selectedPlayer.Assists}\n" +
              //               $"Rebounds: {selectedPlayer.Rebounds}\n" +
                //             $"Matches: {selectedPlayer.Matches}";

         //    picPlayer.ImageLocation = System.IO.File.Exists(selectedPlayer.Photo) ? selectedPlayer.Photo : "default.jpeg";
          //   pnlCardView.BackColor = teamColors.TryGetValue(selectedPlayer.Team, out var color) ? color : Color.White;
         
        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex == -1) return;

            var selectedPlayer = players.FirstOrDefault(p => p.Name == lstPlayers.SelectedItem.ToString());
            if (selectedPlayer == null) return;

            lblName.Text = $"Name: {selectedPlayer.Name}";
            lblTeam.Text = $"Team: {selectedPlayer.Team}";
            picPlayer.ImageLocation = System.IO.File.Exists(selectedPlayer.Photo) ? selectedPlayer.Photo : "default.jpeg";
            pnlCardView.BackColor = teamColors.TryGetValue(selectedPlayer.Team, out var color) ? color : Color.White;

            // Update stats with red/green text
            rtbStats.Clear();
            AppendStat("Points", selectedPlayer.Points, 80);  // Threshold: 80
            AppendStat("Assists", selectedPlayer.Assists, 10); // Threshold: 10
            AppendStat("Rebounds", selectedPlayer.Rebounds, 10); // Threshold: 10
            AppendStat("Matches", selectedPlayer.Matches, 200); // Threshold: 200
        }

        /// <summary>
        /// Appends a stat to the RichTextBox with red or green color based on the value.
        /// </summary>
        /// <param name="statName">Name of the stat (e.g., Points).</param>
        /// <param name="value">Value of the stat.</param>
        /// <param name="threshold">Threshold for determining high or low.</param>
        private void AppendStat(string statName, int value, int threshold)
        {
            rtbStats.SelectionStart = rtbStats.TextLength;
            rtbStats.SelectionLength = 0;

            // Set text color based on the threshold
            rtbStats.SelectionColor = value > threshold ? Color.Green : Color.Red;
            rtbStats.AppendText($"{statName}: {value}\n");

            rtbStats.SelectionColor = rtbStats.ForeColor; // Reset color
        }

        /// <summary>
        /// Opens the ComparisonForm to compare two players.
        /// </summary>
        private void btnOpenComparison_Click(object sender, EventArgs e)
        {
            ComparisonForm comparisonForm = new ComparisonForm(players);
            comparisonForm.ShowDialog();
        }

        /// <summary>
        /// Displays the top-performing player based on points.
        /// </summary>
        private void btnTopPerformer_Click(object sender, EventArgs e)
        {
            var topPerformer = players.OrderByDescending(p => p.Points).FirstOrDefault();
            if (topPerformer != null)
            {
                MessageBox.Show($"{topPerformer.Name} is the top performer with {topPerformer.Points} points!", "Top Performer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Opens a dialog to add a new player.
        /// </summary>
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            if (addPlayerForm.ShowDialog() == DialogResult.OK)
            {
                // Add the new player to the list
                players.Add(addPlayerForm.NewPlayer);

                // Check if the team already has a color, assign a random color if it doesn't
                if (!teamColors.ContainsKey(addPlayerForm.NewPlayer.Team))
                {
                    Random random = new Random();
                    Color randomColor = Color.FromArgb(random.Next(100, 256), random.Next(100, 256), random.Next(100, 256));
                    teamColors.Add(addPlayerForm.NewPlayer.Team, randomColor);
                }

                // Refresh the ListBox
                BindPlayerList();
            }
        }

        /// <summary>
        /// Removes the selected player from the list.
        /// </summary>
        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a player to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPlayer = players.FirstOrDefault(p => p.Name == lstPlayers.SelectedItem.ToString());
            if (selectedPlayer != null)
            {
                players.Remove(selectedPlayer); // Remove the player
                BindPlayerList(); // Refresh the ListBox
            }
        }

        /// <summary>
        /// Initializes team-specific background colors.
        /// </summary>
        /// <returns>A dictionary of team names and their colors.</returns>
        private Dictionary<string, Color> InitializeTeamColors()
        {
            return new Dictionary<string, Color>
            {
                { "RCB", Color.FromArgb(255, 77, 77) },
                { "MI", Color.FromArgb(77, 144, 255) },
                { "CSK", Color.FromArgb(255, 229, 77) },
                { "LSG", Color.FromArgb(77, 179, 77) }
            };
        }
    }

    /// <summary>
    /// Represents a player with all relevant details.
    /// </summary>
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Photo { get; set; }
        public int Points { get; set; }
        public int Assists { get; set; }
        public int Rebounds { get; set; }
        public int Matches { get; set; }
    }
}
