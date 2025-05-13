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
            label2 = new Label();
            cbHomeClub = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbAwayClub = new ComboBox();
            txtScore = new TextBox();
            cbCompetition = new ComboBox();
            btnCancel = new Button();
            btnOK = new Button();
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
            //dtpDate.ValueChanged += this.dtpDate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(286, 71);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Gospodarz";
            // 
            // cbHomeClub
            // 
            cbHomeClub.FormattingEnabled = true;
            cbHomeClub.Location = new Point(286, 94);
            cbHomeClub.Name = "cbHomeClub";
            cbHomeClub.Size = new Size(121, 23);
            cbHomeClub.TabIndex = 3;
            //cbHomeClub.SelectedIndexChanged += this.cbHomeClub_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(286, 128);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Gość";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(286, 186);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 5;
            label4.Text = "Wynik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(286, 245);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 6;
            label5.Text = "Rozgrywki";
            // 
            // cbAwayClub
            // 
            cbAwayClub.FormattingEnabled = true;
            cbAwayClub.Location = new Point(286, 151);
            cbAwayClub.Name = "cbAwayClub";
            cbAwayClub.Size = new Size(121, 23);
            cbAwayClub.TabIndex = 7;
            //cbAwayClub.SelectedIndexChanged += this.cbAwayClub_SelectedIndexChanged;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(286, 209);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 8;
            //txtScore.TextChanged += this.txtScore_TextChanged;
            // 
            // cbCompetition
            // 
            cbCompetition.FormattingEnabled = true;
            cbCompetition.Location = new Point(286, 268);
            cbCompetition.Name = "cbCompetition";
            cbCompetition.Size = new Size(121, 23);
            cbCompetition.TabIndex = 9;
            //cbCompetition.SelectedIndexChanged += this.cbCompetition_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(411, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            //btnCancel.Click += this.btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(330, 330);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // AddMatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(cbCompetition);
            Controls.Add(txtScore);
            Controls.Add(cbAwayClub);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbHomeClub);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddMatchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj mecz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private ComboBox cbHomeClub;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbAwayClub;
        private TextBox txtScore;
        private ComboBox cbCompetition;
        private Button btnCancel;
        private Button btnOK;
    }
}