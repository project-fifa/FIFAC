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
            this.betscreenButton = new System.Windows.Forms.Button();
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
            // 
            // betscreenButton
            // 
            this.betscreenButton.Location = new System.Drawing.Point(442, 6);
            this.betscreenButton.Name = "betscreenButton";
            this.betscreenButton.Size = new System.Drawing.Size(133, 42);
            this.betscreenButton.TabIndex = 1;
            this.betscreenButton.Text = "bieden";
            this.betscreenButton.UseVisualStyleBackColor = true;
            this.betscreenButton.Click += new System.EventHandler(this.betscreenButton_Click);
            // 
            // gameview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 215);
            this.Controls.Add(this.matchListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betscreenButton);
            this.Name = "gameview";
            this.Text = "gameview";
            this.Load += new System.EventHandler(this.gameview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox matchListBox;
        private System.Windows.Forms.Button betscreenButton;
    }
}