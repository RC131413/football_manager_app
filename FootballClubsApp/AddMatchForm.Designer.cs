namespace FootballClubsApp
{
    partial class AddMatchForm
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
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            btnCancel = new Button();
            btnOK = new Button();
            lblSelectedHome = new Label();
            lblSelectedAway = new Label();
            dgvClubs = new DataGridView();
            btnConfirmHome = new Button();
            lblScore = new Label();
            txtScore = new TextBox();
            dgvCompetitions = new DataGridView();
            lblSelectedCompetition = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompetitions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(286, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Data meczu";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(286, 36);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(286, 424);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 6;
            label5.Text = "Rozgrywki";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(482, 630);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(401, 630);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblSelectedHome
            // 
            lblSelectedHome.AutoSize = true;
            lblSelectedHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSelectedHome.Location = new Point(286, 272);
            lblSelectedHome.Name = "lblSelectedHome";
            lblSelectedHome.Size = new Size(149, 20);
            lblSelectedHome.TabIndex = 12;
            lblSelectedHome.Text = "Wybrany gospodarz";
            // 
            // lblSelectedAway
            // 
            lblSelectedAway.AutoSize = true;
            lblSelectedAway.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSelectedAway.Location = new Point(286, 326);
            lblSelectedAway.Name = "lblSelectedAway";
            lblSelectedAway.Size = new Size(108, 20);
            lblSelectedAway.TabIndex = 13;
            lblSelectedAway.Text = "Wybrany gość";
            // 
            // dgvClubs
            // 
            dgvClubs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClubs.Location = new Point(130, 65);
            dgvClubs.Name = "dgvClubs";
            dgvClubs.Size = new Size(520, 150);
            dgvClubs.TabIndex = 14;
            dgvClubs.CellClick += dgvClubs_CellClick;
            // 
            // btnConfirmHome
            // 
            btnConfirmHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnConfirmHome.Location = new Point(469, 221);
            btnConfirmHome.Name = "btnConfirmHome";
            btnConfirmHome.Size = new Size(181, 32);
            btnConfirmHome.TabIndex = 15;
            btnConfirmHome.Text = "Potwierdź gospodarza";
            btnConfirmHome.UseVisualStyleBackColor = true;
            btnConfirmHome.Click += btnConfirmHome_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblScore.Location = new Point(286, 363);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(53, 20);
            lblScore.TabIndex = 17;
            lblScore.Text = "Wynik";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(286, 386);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 18;
            // 
            // dgvCompetitions
            // 
            dgvCompetitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompetitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompetitions.Location = new Point(222, 447);
            dgvCompetitions.Name = "dgvCompetitions";
            dgvCompetitions.Size = new Size(335, 118);
            dgvCompetitions.TabIndex = 19;
            dgvCompetitions.CellClick += dgvCompetitions_CellClick;
            // 
            // lblSelectedCompetition
            // 
            lblSelectedCompetition.AutoSize = true;
            lblSelectedCompetition.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSelectedCompetition.Location = new Point(286, 582);
            lblSelectedCompetition.Name = "lblSelectedCompetition";
            lblSelectedCompetition.Size = new Size(150, 20);
            lblSelectedCompetition.TabIndex = 20;
            lblSelectedCompetition.Text = "Wybrana rozgrywka";
            // 
            // AddMatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 677);
            Controls.Add(lblSelectedCompetition);
            Controls.Add(dgvCompetitions);
            Controls.Add(txtScore);
            Controls.Add(lblScore);
            Controls.Add(btnConfirmHome);
            Controls.Add(dgvClubs);
            Controls.Add(lblSelectedAway);
            Controls.Add(lblSelectedHome);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddMatchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj mecz";
            ((System.ComponentModel.ISupportInitialize)dgvClubs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompetitions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label5;
        private Button btnCancel;
        private Button btnOK;
        private Label lblSelectedHome;
        private Label lblSelectedAway;
        private DataGridView dgvClubs;
        private Button btnConfirmHome;
        private Label lblScore;
        private TextBox txtScore;
        private DataGridView dgvCompetitions;
        private Label lblSelectedCompetition;
    }
}