namespace FootballClubsApp
{
    partial class CompetitionsView
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
            btnAddCompetiotion = new Button();
            dgvCompetitions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCompetitions).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(168, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Lista rozgrywek";
            // 
            // btnAddCompetiotion
            // 
            btnAddCompetiotion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCompetiotion.Location = new Point(335, 0);
            btnAddCompetiotion.Name = "btnAddCompetiotion";
            btnAddCompetiotion.Size = new Size(115, 30);
            btnAddCompetiotion.TabIndex = 1;
            btnAddCompetiotion.Text = "Dodaj rozgrywki";
            btnAddCompetiotion.UseVisualStyleBackColor = true;
            btnAddCompetiotion.Click += btnAddCompetition_Click;
            // 
            // dgvCompetitions
            // 
            dgvCompetitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompetitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompetitions.Dock = DockStyle.Fill;
            dgvCompetitions.Location = new Point(0, 30);
            dgvCompetitions.Name = "dgvCompetitions";
            dgvCompetitions.Size = new Size(450, 301);
            dgvCompetitions.TabIndex = 2;
            // 
            // CompetitionsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvCompetitions);
            Controls.Add(btnAddCompetiotion);
            Controls.Add(lblHeader);
            Name = "CompetitionsView";
            Size = new Size(450, 331);
            ((System.ComponentModel.ISupportInitialize)dgvCompetitions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnAddCompetiotion;
        private DataGridView dgvCompetitions;
    }
}
