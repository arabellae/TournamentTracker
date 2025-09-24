namespace ProjectTrackerUI
{
    partial class CreateTournamentForm
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
            addTeamButton = new Button();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            tournamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            headerLabel = new Label();
            selectTeamDropdown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLabel = new LinkLabel();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            torunamentPlayersLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTorunamentButton = new Button();
            SuspendLayout();
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTeamButton.Location = new Point(128, 621);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(403, 58);
            addTeamButton.TabIndex = 27;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += scoreButton_Click;
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(229, 335);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(188, 65);
            entryFeeValue.TabIndex = 25;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryFeeLabel.Location = new Point(53, 345);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(172, 50);
            entryFeeLabel.TabIndex = 24;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(53, 196);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(527, 65);
            tournamentNameValue.TabIndex = 22;
            tournamentNameValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.ForeColor = SystemColors.Highlight;
            TournamentNameLabel.Location = new Point(40, 134);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(377, 59);
            TournamentNameLabel.TabIndex = 16;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.Highlight;
            headerLabel.Location = new Point(40, 33);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(430, 65);
            headerLabel.TabIndex = 14;
            headerLabel.Text = "Create Tournament";
            headerLabel.Click += headerLabel_Click;
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(53, 509);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(527, 67);
            selectTeamDropdown.TabIndex = 29;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamLabel.Location = new Point(53, 436);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(214, 50);
            selectTeamLabel.TabIndex = 28;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLabel
            // 
            createNewTeamLabel.AutoSize = true;
            createNewTeamLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNewTeamLabel.Location = new Point(273, 436);
            createNewTeamLabel.Name = "createNewTeamLabel";
            createNewTeamLabel.Size = new Size(307, 50);
            createNewTeamLabel.TabIndex = 30;
            createNewTeamLabel.TabStop = true;
            createNewTeamLabel.Text = "Create New Team";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeButton.Location = new Point(128, 710);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(403, 58);
            createPrizeButton.TabIndex = 31;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 59;
            tournamentPlayersListBox.Location = new Point(805, 253);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(528, 179);
            tournamentPlayersListBox.TabIndex = 32;
            // 
            // torunamentPlayersLabel
            // 
            torunamentPlayersLabel.AutoSize = true;
            torunamentPlayersLabel.ForeColor = SystemColors.Highlight;
            torunamentPlayersLabel.Location = new Point(805, 172);
            torunamentPlayersLabel.Name = "torunamentPlayersLabel";
            torunamentPlayersLabel.Size = new Size(316, 59);
            torunamentPlayersLabel.TabIndex = 33;
            torunamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPlayerButton.Location = new Point(1417, 265);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(219, 150);
            deleteSelectedPlayerButton.TabIndex = 34;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteSelectedPrizeButton.Location = new Point(1417, 606);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(219, 162);
            deleteSelectedPrizeButton.TabIndex = 37;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.ForeColor = SystemColors.Highlight;
            prizesLabel.Location = new Point(805, 508);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(316, 59);
            prizesLabel.TabIndex = 36;
            prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 59;
            prizesListBox.Location = new Point(805, 589);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(528, 179);
            prizesListBox.TabIndex = 35;
            // 
            // createTorunamentButton
            // 
            createTorunamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTorunamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTorunamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTorunamentButton.FlatStyle = FlatStyle.Flat;
            createTorunamentButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTorunamentButton.Location = new Point(460, 920);
            createTorunamentButton.Name = "createTorunamentButton";
            createTorunamentButton.Size = new Size(742, 172);
            createTorunamentButton.TabIndex = 38;
            createTorunamentButton.Text = "Create Tournament";
            createTorunamentButton.UseVisualStyleBackColor = true;
            createTorunamentButton.Click += button1_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1719, 1145);
            Controls.Add(createTorunamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(torunamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(createNewTeamLabel);
            Controls.Add(selectTeamDropdown);
            Controls.Add(selectTeamLabel);
            Controls.Add(addTeamButton);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(TournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreateTournamentForm";
            Text = "Tournament Name";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTeamButton;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private TextBox tournamentNameValue;
        private ListBox matchupListBox;
        private CheckBox unplayedOnlyCheckbox;
        private ComboBox roundDropdown;
        private Label TournamentNameLabel;
        private Label headerLabel;
        private ComboBox selectTeamDropdown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLabel;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label torunamentPlayersLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTorunamentButton;
    }
}