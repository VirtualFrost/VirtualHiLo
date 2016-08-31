namespace VirtualHiLo
{
    partial class virtualHiLo
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
            this.newGameBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.guessLbl = new System.Windows.Forms.Label();
            this.remainingGuessLbl = new System.Windows.Forms.Label();
            this.guessesLbl = new System.Windows.Forms.Label();
            this.gameMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyGuessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumGuessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardGuessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertGuessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(9, 34);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Location = new System.Drawing.Point(333, 24);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(214, 137);
            this.resultTextBox.TabIndex = 3;
            this.resultTextBox.TabStop = false;
            this.resultTextBox.Text = "Click \"New Game\" to begin.";
            // 
            // guessBtn
            // 
            this.guessBtn.Location = new System.Drawing.Point(155, 70);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(75, 20);
            this.guessBtn.TabIndex = 2;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(80, 70);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(69, 20);
            this.userInputTextBox.TabIndex = 1;
            // 
            // guessLbl
            // 
            this.guessLbl.AutoSize = true;
            this.guessLbl.Location = new System.Drawing.Point(6, 73);
            this.guessLbl.Name = "guessLbl";
            this.guessLbl.Size = new System.Drawing.Size(68, 13);
            this.guessLbl.TabIndex = 6;
            this.guessLbl.Text = "Enter Guess:";
            // 
            // remainingGuessLbl
            // 
            this.remainingGuessLbl.AutoSize = true;
            this.remainingGuessLbl.Location = new System.Drawing.Point(6, 137);
            this.remainingGuessLbl.Name = "remainingGuessLbl";
            this.remainingGuessLbl.Size = new System.Drawing.Size(104, 13);
            this.remainingGuessLbl.TabIndex = 7;
            this.remainingGuessLbl.Text = "Remaining Guesses:";
            // 
            // guessesLbl
            // 
            this.guessesLbl.AutoSize = true;
            this.guessesLbl.Location = new System.Drawing.Point(116, 137);
            this.guessesLbl.Name = "guessesLbl";
            this.guessesLbl.Size = new System.Drawing.Size(13, 13);
            this.guessesLbl.TabIndex = 8;
            this.guessesLbl.Text = "0";
            // 
            // gameMenuStrip
            // 
            this.gameMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.gameMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.gameMenuStrip.Name = "gameMenuStrip";
            this.gameMenuStrip.Size = new System.Drawing.Size(547, 24);
            this.gameMenuStrip.TabIndex = 9;
            this.gameMenuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyGuessMenuItem,
            this.mediumGuessMenuItem,
            this.hardGuessMenuItem,
            this.expertGuessMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyGuessMenuItem
            // 
            this.easyGuessMenuItem.Name = "easyGuessMenuItem";
            this.easyGuessMenuItem.Size = new System.Drawing.Size(181, 22);
            this.easyGuessMenuItem.Text = "Easy (10 Guesses)";
            this.easyGuessMenuItem.Click += new System.EventHandler(this.easyGuessMenuItem_Click);
            // 
            // mediumGuessMenuItem
            // 
            this.mediumGuessMenuItem.Name = "mediumGuessMenuItem";
            this.mediumGuessMenuItem.Size = new System.Drawing.Size(181, 22);
            this.mediumGuessMenuItem.Text = "Medium (7 Guesses)";
            this.mediumGuessMenuItem.Click += new System.EventHandler(this.mediumGuessMenuItem_Click);
            // 
            // hardGuessMenuItem
            // 
            this.hardGuessMenuItem.Name = "hardGuessMenuItem";
            this.hardGuessMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hardGuessMenuItem.Text = "Hard (5 Guesses)";
            this.hardGuessMenuItem.Click += new System.EventHandler(this.hardGuessMenuItem_Click);
            // 
            // expertGuessMenuItem
            // 
            this.expertGuessMenuItem.Name = "expertGuessMenuItem";
            this.expertGuessMenuItem.Size = new System.Drawing.Size(181, 22);
            this.expertGuessMenuItem.Text = "Expert (3 Guesses)";
            this.expertGuessMenuItem.Click += new System.EventHandler(this.expertGuessMenuItem_Click);
            // 
            // virtualHiLo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(547, 160);
            this.Controls.Add(this.guessesLbl);
            this.Controls.Add(this.remainingGuessLbl);
            this.Controls.Add(this.guessLbl);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.gameMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.gameMenuStrip;
            this.Name = "virtualHiLo";
            this.Text = "Virtual HiLo";
            this.gameMenuStrip.ResumeLayout(false);
            this.gameMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Label guessLbl;
        private System.Windows.Forms.Label remainingGuessLbl;
        private System.Windows.Forms.Label guessesLbl;
        private System.Windows.Forms.MenuStrip gameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyGuessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumGuessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardGuessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertGuessMenuItem;
    }
}

