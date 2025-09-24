namespace ProjectTrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            label1 = new Label();
            roundLabel = new Label();
            roundDropdown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(12, 37);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(261, 59);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 37);
            label1.Name = "label1";
            label1.Size = new Size(178, 59);
            label1.TabIndex = 1;
            label1.Text = "<none>";
            label1.Click += label1_Click;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(12, 115);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(148, 59);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(177, 107);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(363, 67);
            roundDropdown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Location = new Point(177, 214);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(330, 63);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 59;
            matchupListBox.Location = new Point(12, 328);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(528, 474);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Location = new Point(710, 328);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(262, 59);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(710, 445);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(130, 59);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(858, 439);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(200, 65);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(858, 736);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(200, 65);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(710, 742);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(130, 59);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Location = new Point(710, 625);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(262, 59);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Location = new Point(858, 540);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(104, 59);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "- VS";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.Location = new Point(1192, 513);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(219, 113);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 1232);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropdown);
            Controls.Add(roundLabel);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label label1;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}
