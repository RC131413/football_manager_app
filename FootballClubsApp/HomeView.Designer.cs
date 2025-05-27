namespace FootballClubsApp
{
    partial class HomeView
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMatchCount = new Label();
            lblTeamCount = new Label();
            lblCompetitionCount = new Label();
            lblClubsCount = new Label();
            lblCompetitionsCount = new Label();
            lblMatchesCount = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTitle.Location = new Point(122, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(3, 0, 3, 0);
            lblTitle.Size = new Size(326, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Witaj w Footbal Club Manager!";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel1.Controls.Add(lblMatchCount, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTeamCount, 1, 0);
            tableLayoutPanel1.Controls.Add(lblCompetitionCount, 2, 0);
            tableLayoutPanel1.Controls.Add(lblClubsCount, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCompetitionsCount, 2, 1);
            tableLayoutPanel1.Controls.Add(lblMatchesCount, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1428576F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.85714F));
            tableLayoutPanel1.Size = new Size(556, 350);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblMatchCount
            // 
            lblMatchCount.AutoSize = true;
            lblMatchCount.Dock = DockStyle.Fill;
            lblMatchCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblMatchCount.Location = new Point(3, 0);
            lblMatchCount.Name = "lblMatchCount";
            lblMatchCount.Size = new Size(143, 39);
            lblMatchCount.TabIndex = 0;
            lblMatchCount.Text = "Liczba meczów";
            lblMatchCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeamCount
            // 
            lblTeamCount.AutoSize = true;
            lblTeamCount.Dock = DockStyle.Fill;
            lblTeamCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTeamCount.Location = new Point(152, 0);
            lblTeamCount.Name = "lblTeamCount";
            lblTeamCount.Size = new Size(199, 39);
            lblTeamCount.TabIndex = 1;
            lblTeamCount.Text = "Liczba drużyn";
            lblTeamCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompetitionCount
            // 
            lblCompetitionCount.AutoSize = true;
            lblCompetitionCount.Dock = DockStyle.Fill;
            lblCompetitionCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCompetitionCount.Location = new Point(357, 0);
            lblCompetitionCount.Name = "lblCompetitionCount";
            lblCompetitionCount.Size = new Size(196, 39);
            lblCompetitionCount.TabIndex = 2;
            lblCompetitionCount.Text = "Liczba rozgrywek";
            lblCompetitionCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClubsCount
            // 
            lblClubsCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblClubsCount.AutoSize = true;
            lblClubsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblClubsCount.Location = new Point(152, 39);
            lblClubsCount.Name = "lblClubsCount";
            lblClubsCount.Size = new Size(199, 20);
            lblClubsCount.TabIndex = 4;
            lblClubsCount.Text = "pole liczby druzyn";
            lblClubsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompetitionsCount
            // 
            lblCompetitionsCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCompetitionsCount.AutoSize = true;
            lblCompetitionsCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCompetitionsCount.Location = new Point(357, 39);
            lblCompetitionsCount.Name = "lblCompetitionsCount";
            lblCompetitionsCount.Size = new Size(196, 20);
            lblCompetitionsCount.TabIndex = 5;
            lblCompetitionsCount.Text = "pole liczby rozgrywek";
            lblCompetitionsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMatchesCount
            // 
            lblMatchesCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMatchesCount.AutoSize = true;
            lblMatchesCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblMatchesCount.Location = new Point(3, 39);
            lblMatchesCount.Name = "lblMatchesCount";
            lblMatchesCount.Size = new Size(143, 20);
            lblMatchesCount.TabIndex = 3;
            lblMatchesCount.Text = "pole liczby meczow";
            lblMatchesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblTitle);
            Name = "HomeView";
            Size = new Size(556, 383);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMatchCount;
        private Label lblTeamCount;
        private Label lblCompetitionCount;
        private Label lblClubsCount;
        private Label lblCompetitionsCount;
        private Label lblMatchesCount;
    }
}
