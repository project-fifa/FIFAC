namespace VoetbalToernooi
{
    partial class gameview
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
            this.label2 = new System.Windows.Forms.Label();
            this.matchListBox = new System.Windows.Forms.ListBox();
            this.matchButton = new System.Windows.Forms.Button();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.winOrLoseButton = new System.Windows.Forms.Button();
            this.matchLabel = new System.Windows.Forms.Label();
            this.teamBetLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wedstrijd waar je op gaat bieden:\r\n";
            // 
            // matchListBox
            // 
            this.matchListBox.FormattingEnabled = true;
            this.matchListBox.ItemHeight = 16;
            this.matchListBox.Location = new System.Drawing.Point(33, 54);
            this.matchListBox.Name = "matchListBox";
            this.matchListBox.Size = new System.Drawing.Size(535, 132);
            this.matchListBox.TabIndex = 11;
            this.matchListBox.SelectedIndexChanged += new System.EventHandler(this.matchListBox_SelectedIndexChanged);
            // 
            // matchButton
            // 
            this.matchButton.Location = new System.Drawing.Point(33, 193);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(535, 40);
            this.matchButton.TabIndex = 12;
            this.matchButton.Text = "Maak wedstrijdschema";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // teamComboBox
            // 
            this.teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(33, 269);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(318, 24);
            this.teamComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Welk team gaat er winnen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "bedrag in € dat je gaat inzetten";
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(254, 310);
            this.betNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.betNumericUpDown.TabIndex = 16;
            this.betNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "balans:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(169, 341);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(66, 46);
            this.balanceLabel.TabIndex = 18;
            this.balanceLabel.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "€";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(408, 289);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(142, 59);
            this.betButton.TabIndex = 20;
            this.betButton.Text = "bied";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // winOrLoseButton
            // 
            this.winOrLoseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winOrLoseButton.Location = new System.Drawing.Point(593, 113);
            this.winOrLoseButton.Name = "winOrLoseButton";
            this.winOrLoseButton.Size = new System.Drawing.Size(336, 73);
            this.winOrLoseButton.TabIndex = 21;
            this.winOrLoseButton.Text = "kijk of u geld heeft gewonnen met uw weddenschap";
            this.winOrLoseButton.UseVisualStyleBackColor = true;
            this.winOrLoseButton.Click += new System.EventHandler(this.winOrLoseButton_Click);
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.Location = new System.Drawing.Point(603, 54);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(0, 17);
            this.matchLabel.TabIndex = 22;
            // 
            // teamBetLabel
            // 
            this.teamBetLabel.AutoSize = true;
            this.teamBetLabel.Location = new System.Drawing.Point(790, 54);
            this.teamBetLabel.Name = "teamBetLabel";
            this.teamBetLabel.Size = new System.Drawing.Size(0, 17);
            this.teamBetLabel.TabIndex = 23;
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Location = new System.Drawing.Point(730, 54);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(0, 17);
            this.euroLabel.TabIndex = 24;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(752, 54);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(0, 17);
            this.betLabel.TabIndex = 25;
            // 
            // gameview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 407);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.euroLabel);
            this.Controls.Add(this.teamBetLabel);
            this.Controls.Add(this.matchLabel);
            this.Controls.Add(this.winOrLoseButton);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamComboBox);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.matchListBox);
            this.Controls.Add(this.label2);
            this.Name = "gameview";
            this.Text = "gameview";
            this.Load += new System.EventHandler(this.gameview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox matchListBox;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Button winOrLoseButton;
        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.Label teamBetLabel;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.Label betLabel;
    }
}