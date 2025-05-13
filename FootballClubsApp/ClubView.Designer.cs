namespace FootballClubsApp
{
    partial class ClubView
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
            btnAddClub = new Button();
            dgvClubs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(251, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Lista klubów piłkarskich";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddClub
            // 
            btnAddClub.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddClub.Location = new Point(316, -1);
            btnAddClub.Name = "btnAddClub";
            btnAddClub.Size = new Size(115, 30);
            btnAddClub.TabIndex = 1;
            btnAddClub.Text = "Dodaj klub";
            btnAddClub.UseVisualStyleBackColor = true;
            btnAddClub.Click += btnAddClub_Click;
            // 
            // dgvClubs
            // 
            dgvClubs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClubs.Dock = DockStyle.Fill;
            dgvClubs.Location = new Point(0, 30);
            dgvClubs.Name = "dgvClubs";
            dgvClubs.ReadOnly = true;
            dgvClubs.Size = new Size(431, 308);
            dgvClubs.TabIndex = 2;
            // 
            // ClubView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvClubs);
            Controls.Add(btnAddClub);
            Controls.Add(lblHeader);
            Name = "ClubView";
            Size = new Size(431, 338);
            ((System.ComponentModel.ISupportInitialize)dgvClubs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnAddClub;
        private DataGridView dgvClubs;
    }
}
