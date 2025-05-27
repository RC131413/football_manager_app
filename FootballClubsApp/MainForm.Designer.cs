namespace FootballClubsApp
{
    partial class MainForm
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
            panelNav = new Panel();
            btnHome = new Button();
            btnMatches = new Button();
            btnClubs = new Button();
            btnCompetitions = new Button();
            panelContent = new Panel();
            btnPlayers = new Button();
            panelNav.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = SystemColors.ControlDarkDark;
            panelNav.Controls.Add(btnPlayers);
            panelNav.Controls.Add(btnHome);
            panelNav.Controls.Add(btnMatches);
            panelNav.Controls.Add(btnClubs);
            panelNav.Controls.Add(btnCompetitions);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.MinimumSize = new Size(180, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(191, 450);
            panelNav.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(191, 32);
            btnHome.TabIndex = 0;
            btnHome.Text = "Strona główna";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnMatches
            // 
            btnMatches.Location = new Point(0, 38);
            btnMatches.Name = "btnMatches";
            btnMatches.Size = new Size(191, 29);
            btnMatches.TabIndex = 1;
            btnMatches.Text = "Mecze";
            btnMatches.UseVisualStyleBackColor = true;
            btnMatches.Click += btnMatches_Click;
            // 
            // btnClubs
            // 
            btnClubs.Location = new Point(0, 73);
            btnClubs.Name = "btnClubs";
            btnClubs.Size = new Size(191, 25);
            btnClubs.TabIndex = 2;
            btnClubs.Text = "Kluby";
            btnClubs.UseVisualStyleBackColor = true;
            btnClubs.Click += button1_Click;
            // 
            // btnCompetitions
            // 
            btnCompetitions.Location = new Point(0, 104);
            btnCompetitions.Name = "btnCompetitions";
            btnCompetitions.Size = new Size(191, 25);
            btnCompetitions.TabIndex = 3;
            btnCompetitions.Text = "Rozgrywki";
            btnCompetitions.UseVisualStyleBackColor = true;
            btnCompetitions.Click += btnCompetitions_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(191, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(609, 450);
            panelContent.TabIndex = 1;
            // 
            // btnPlayers
            // 
            btnPlayers.Location = new Point(0, 135);
            btnPlayers.Name = "btnPlayers";
            btnPlayers.Size = new Size(191, 27);
            btnPlayers.TabIndex = 2;
            btnPlayers.Text = "Zawodnicy";
            btnPlayers.UseVisualStyleBackColor = true;
            btnPlayers.Click += btnPlayers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Name = "MainForm";
            Text = "Form1";
            panelNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Button btnCompetitions;
        private Button btnMatches;
        private Button btnClubs;
        private Panel panelContent;
        private Button btnHome;
        private Button btnPlayers;
    }
}