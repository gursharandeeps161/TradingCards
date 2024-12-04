namespace TradingCards
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.pnlCardView = new System.Windows.Forms.Panel();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
         //   this.lblStats = new System.Windows.Forms.Label();
            this.btnOpenComparison = new System.Windows.Forms.Button();
            this.btnTopPerformer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.pnlCardView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 25;
            this.lstPlayers.Location = new System.Drawing.Point(10, 10);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(200, 475);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // pnlCardView
            // 
            this.pnlCardView.BackColor = System.Drawing.Color.White;
            this.pnlCardView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardView.Controls.Add(this.picPlayer);
            this.pnlCardView.Controls.Add(this.lblName);
            this.pnlCardView.Controls.Add(this.lblTeam);
          //  this.pnlCardView.Controls.Add(this.lblStats);
            this.pnlCardView.Location = new System.Drawing.Point(220, 10);
            this.pnlCardView.Name = "pnlCardView";
            this.pnlCardView.Size = new System.Drawing.Size(560, 350);
            this.pnlCardView.TabIndex = 1;
            // 
            // picPlayer
            // 
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer.Location = new System.Drawing.Point(205, 20);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(150, 150);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(200, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: Player";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTeam.Location = new System.Drawing.Point(220, 220);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(120, 25);
            this.lblTeam.TabIndex = 2;
            this.lblTeam.Text = "Team: Team";
            this.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStats
            /*  // 
              this.lblStats.Font = new System.Drawing.Font("Segoe UI", 12F);
              this.lblStats.Location = new System.Drawing.Point(150, 220);
              this.lblStats.Name = "lblStats";
              this.lblStats.Size = new System.Drawing.Size(600, 600);
              this.lblStats.TabIndex = 3;
              this.lblStats.Text = "Points: \nAssists: \nRebounds: \nMatches:";
              this.lblStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
             */ // 
                // lblStats (replaced with rtbStats)
            this.rtbStats = new System.Windows.Forms.RichTextBox();
            this.rtbStats.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rtbStats.Location = new System.Drawing.Point(600, 230);
            this.rtbStats.Name = "rtbStats";
            this.rtbStats.Size = new System.Drawing.Size(160, 120); // Adjusted size
            this.rtbStats.TabIndex = 3;
            this.rtbStats.ReadOnly = true; // Make it read-only
            this.rtbStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStats.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rtbStats);

            // btnOpenComparison
            // 
            this.btnOpenComparison.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOpenComparison.Location = new System.Drawing.Point(220, 370);
            this.btnOpenComparison.Name = "btnOpenComparison";
            this.btnOpenComparison.Size = new System.Drawing.Size(150, 40);
            this.btnOpenComparison.TabIndex = 4;
            this.btnOpenComparison.Text = "Compare Players";
            this.btnOpenComparison.UseVisualStyleBackColor = true;
            this.btnOpenComparison.Click += new System.EventHandler(this.btnOpenComparison_Click);
            // 
            // btnTopPerformer
            // 
            this.btnTopPerformer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTopPerformer.Location = new System.Drawing.Point(380, 370);
            this.btnTopPerformer.Name = "btnTopPerformer";
            this.btnTopPerformer.Size = new System.Drawing.Size(150, 40);
            this.btnTopPerformer.TabIndex = 5;
            this.btnTopPerformer.Text = "Top Performer";
            this.btnTopPerformer.UseVisualStyleBackColor = true;
            this.btnTopPerformer.Click += new System.EventHandler(this.btnTopPerformer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddPlayer.Location = new System.Drawing.Point(540, 370);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(120, 40);
            this.btnAddPlayer.TabIndex = 6;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemovePlayer.Location = new System.Drawing.Point(670, 370);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(120, 40);
            this.btnRemovePlayer.TabIndex = 7;
            this.btnRemovePlayer.Text = "Remove Player";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.btnTopPerformer);
            this.Controls.Add(this.btnOpenComparison);
            this.Controls.Add(this.pnlCardView);
            this.Controls.Add(this.lstPlayers);
            this.Name = "Form1";
            this.Text = "Trading Cards - Indian Cricket Players";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCardView.ResumeLayout(false);
            this.pnlCardView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Panel pnlCardView;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.RichTextBox rtbStats; 

        //   private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnOpenComparison;
        private System.Windows.Forms.Button btnTopPerformer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnRemovePlayer;

    }
}
