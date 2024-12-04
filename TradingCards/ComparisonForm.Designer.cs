namespace TradingCards
{
    partial class ComparisonForm
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
            cmbPlayer1 = new ComboBox();
            cmbPlayer2 = new ComboBox();
            btnCompare = new Button();
            lblComparisonResult = new Label();
            SuspendLayout();
            // 
            // cmbPlayer1
            // 
            cmbPlayer1.Font = new Font("Segoe UI", 12F);
            cmbPlayer1.FormattingEnabled = true;
            cmbPlayer1.Location = new Point(50, 50);
            cmbPlayer1.Name = "cmbPlayer1";
            cmbPlayer1.Size = new Size(200, 36);
            cmbPlayer1.TabIndex = 0;
            // 
            // cmbPlayer2
            // 
            cmbPlayer2.Font = new Font("Segoe UI", 12F);
            cmbPlayer2.FormattingEnabled = true;
            cmbPlayer2.Location = new Point(300, 50);
            cmbPlayer2.Name = "cmbPlayer2";
            cmbPlayer2.Size = new Size(200, 36);
            cmbPlayer2.TabIndex = 1;
            // 
            // btnCompare
            // 
            btnCompare.Font = new Font("Segoe UI", 12F);
            btnCompare.Location = new Point(200, 100);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(150, 40);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // lblComparisonResult
            // 
            lblComparisonResult.BorderStyle = BorderStyle.FixedSingle;
            lblComparisonResult.Font = new Font("Segoe UI", 12F);
            lblComparisonResult.Location = new Point(20, 170);
            lblComparisonResult.Name = "lblComparisonResult";
            lblComparisonResult.Size = new Size(520, 221);
            lblComparisonResult.TabIndex = 3;
            lblComparisonResult.Text = "Comparison result will appear here...";
            // 
            // ComparisonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 400);
            Controls.Add(lblComparisonResult);
            Controls.Add(btnCompare);
            Controls.Add(cmbPlayer2);
            Controls.Add(cmbPlayer1);
            Name = "ComparisonForm";
            Text = "Player Comparison";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPlayer1;
        private System.Windows.Forms.ComboBox cmbPlayer2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblComparisonResult;
    }
}
