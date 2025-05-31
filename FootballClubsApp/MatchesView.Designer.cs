namespace FootballClubsApp
{
    partial class MatchesView
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
            btnAddMatch = new Button();
            dgvMatches = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(144, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Lista meczów";
            // 
            // btnAddMatch
            // 
            btnAddMatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddMatch.Location = new Point(361, 0);
            btnAddMatch.Name = "btnAddMatch";
            btnAddMatch.Size = new Size(115, 30);
            btnAddMatch.TabIndex = 1;
            btnAddMatch.Text = "Dodaj mecz";
            btnAddMatch.UseVisualStyleBackColor = true;
            btnAddMatch.Click += btnAddMatch_Click;
            // 
            // dgvMatches
            // 
            dgvMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatches.Dock = DockStyle.Fill;
            dgvMatches.Location = new Point(0, 30);
            dgvMatches.Name = "dgvMatches";
            dgvMatches.Size = new Size(476, 278);
            dgvMatches.TabIndex = 2;
            dgvMatches.CellDoubleClick += dgvMatches_CellDoubleClick;
            // 
            // MatchesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvMatches);
            Controls.Add(btnAddMatch);
            Controls.Add(lblHeader);
            Name = "MatchesView";
            Size = new Size(476, 308);
            ((System.ComponentModel.ISupportInitialize)dgvMatches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnAddMatch;
        private DataGridView dgvMatches;
    }
}
