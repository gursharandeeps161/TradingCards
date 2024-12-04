using System;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class AddPlayerForm : Form
    {
        public Player NewPlayer { get; private set; }

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtTeam.Text) ||
                !int.TryParse(txtPoints.Text, out int points) ||
                !int.TryParse(txtAssists.Text, out int assists) ||
                !int.TryParse(txtRebounds.Text, out int rebounds) ||
                !int.TryParse(txtMatches.Text, out int matches))
            {
                MessageBox.Show("Please fill out all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewPlayer = new Player
            {
                Name = txtName.Text,
                Team = txtTeam.Text,
                Points = points,
                Assists = assists,
                Rebounds = rebounds,
                Matches = matches,
                Photo = "default.jpg" // Default photo
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
