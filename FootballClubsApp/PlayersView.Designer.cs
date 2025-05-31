namespace FootballClubsApp
{
    partial class PlayersView
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
            lblHeader = new Label();
            btnAddPlayer = new Button();
            dgvPlayers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(120, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Zawodnicy";
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPlayer.Location = new Point(405, 0);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(129, 30);
            btnAddPlayer.TabIndex = 1;
            btnAddPlayer.Text = "Dodaj zawodnika";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // dgvPlayers
            // 
            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayers.Dock = DockStyle.Fill;
            dgvPlayers.Location = new Point(0, 30);
            dgvPlayers.Name = "dgvPlayers";
            dgvPlayers.Size = new Size(534, 342);
            dgvPlayers.TabIndex = 2;
            // 
            // PlayersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPlayers);
            Controls.Add(btnAddPlayer);
            Controls.Add(lblHeader);
            Name = "PlayersView";
            Size = new Size(534, 372);
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnAddPlayer;
        private DataGridView dgvPlayers;
    }
}
