namespace VoetbalToernooi
{
    partial class betscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.balanceTextLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.betUpDown = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matchInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceTextLabel
            // 
            this.balanceTextLabel.AutoSize = true;
            this.balanceTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTextLabel.Location = new System.Drawing.Point(30, 43);
            this.balanceTextLabel.Name = "balanceTextLabel";
            this.balanceTextLabel.Size = new System.Drawing.Size(315, 24);
            this.balanceTextLabel.TabIndex = 4;
            this.balanceTextLabel.Text = "balans:                                               €";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(363, 43);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(41, 29);
            this.balanceLabel.TabIndex = 5;
            this.balanceLabel.Text = "50";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.betLabel.Location = new System.Drawing.Point(31, 90);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(316, 24);
            this.betLabel.TabIndex = 7;
            this.betLabel.Text = "bedrag dat je gaat inzeten                €";
            // 
            // betUpDown
            // 
            this.betUpDown.Location = new System.Drawing.Point(368, 92);
            this.betUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.betUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betUpDown.Name = "betUpDown";
            this.betUpDown.Size = new System.Drawing.Size(92, 22);
            this.betUpDown.TabIndex = 11;
            this.betUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(520, 54);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(169, 60);
            this.betButton.TabIndex = 12;
            this.betButton.Text = "Zet in";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(30, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Wedstrijd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "U heeft minimaal €5,- om te kunnen bieden\r\n";
            // 
            // matchInfoLabel
            // 
            this.matchInfoLabel.AutoSize = true;
            this.matchInfoLabel.Location = new System.Drawing.Point(175, 18);
            this.matchInfoLabel.Name = "matchInfoLabel";
            this.matchInfoLabel.Size = new System.Drawing.Size(188, 17);
            this.matchInfoLabel.TabIndex = 15;
            this.matchInfoLabel.Text = "Geen wedstrijd geselecteerd";
            // 
            // betscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 167);
            this.Controls.Add(this.matchInfoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.betUpDown);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceTextLabel);
            this.Name = "betscreen";
            this.Text = "betscreen";
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balanceTextLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.NumericUpDown betUpDown;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label matchInfoLabel;
    }
}