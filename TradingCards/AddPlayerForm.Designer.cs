namespace TradingCards
{
    partial class AddPlayerForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.txtAssists = new System.Windows.Forms.TextBox();
            this.txtRebounds = new System.Windows.Forms.TextBox();
            this.txtMatches = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 30);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Player Name";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 0;
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(30, 70);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.PlaceholderText = "Team";
            this.txtTeam.Size = new System.Drawing.Size(200, 27);
            this.txtTeam.TabIndex = 1;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(30, 110);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.PlaceholderText = "Points";
            this.txtPoints.Size = new System.Drawing.Size(200, 27);
            this.txtPoints.TabIndex = 2;
            // 
            // txtAssists
            // 
            this.txtAssists.Location = new System.Drawing.Point(30, 150);
            this.txtAssists.Name = "txtAssists";
            this.txtAssists.PlaceholderText = "Assists";
            this.txtAssists.Size = new System.Drawing.Size(200, 27);
            this.txtAssists.TabIndex = 3;
            // 
            // txtRebounds
            // 
            this.txtRebounds.Location = new System.Drawing.Point(30, 190);
            this.txtRebounds.Name = "txtRebounds";
            this.txtRebounds.PlaceholderText = "Rebounds";
            this.txtRebounds.Size = new System.Drawing.Size(200, 27);
            this.txtRebounds.TabIndex = 4;
            // 
            // txtMatches
            // 
            this.txtMatches.Location = new System.Drawing.Point(30, 230);
            this.txtMatches.Name = "txtMatches";
            this.txtMatches.PlaceholderText = "Matches";
            this.txtMatches.Size = new System.Drawing.Size(200, 27);
            this.txtMatches.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddPlayerForm
            // 
            this.ClientSize = new System.Drawing.Size(260, 340);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMatches);
            this.Controls.Add(this.txtRebounds);
            this.Controls.Add(this.txtAssists);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.txtName);
            this.Name = "AddPlayerForm";
            this.Text = "Add Player";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.TextBox txtAssists;
        private System.Windows.Forms.TextBox txtRebounds;
        private System.Windows.Forms.TextBox txtMatches;
        private System.Windows.Forms.Button btnAdd;
    }
}
