namespace FootballClubsApp
{
    partial class AddCompetitionForm
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
            numTeams = new NumericUpDown();
            txtSeason = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            txtCompetitionName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbType = new ComboBox();
            cbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numTeams).BeginInit();
            SuspendLayout();
            // 
            // numTeams
            // 
            numTeams.Location = new Point(300, 253);
            numTeams.Name = "numTeams";
            numTeams.Size = new Size(120, 23);
            numTeams.TabIndex = 38;
            // 
            // txtSeason
            // 
            txtSeason.Location = new Point(300, 198);
            txtSeason.Name = "txtSeason";
            txtSeason.Size = new Size(100, 23);
            txtSeason.TabIndex = 37;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(344, 374);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 35;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(425, 374);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCompetitionName
            // 
            txtCompetitionName.Location = new Point(300, 76);
            txtCompetitionName.Name = "txtCompetitionName";
            txtCompetitionName.Size = new Size(100, 23);
            txtCompetitionName.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(300, 289);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 32;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(300, 230);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 31;
            label4.Text = "Liczba drużyn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(300, 172);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 30;
            label3.Text = "Sezon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(300, 115);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 29;
            label2.Text = "Typ rozgrywek";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(300, 53);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 27;
            label1.Text = "Nazwa rozgrywek";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(300, 138);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 39;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(300, 312);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 23);
            cbStatus.TabIndex = 40;
            // 
            // AddCompetitionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbStatus);
            Controls.Add(cbType);
            Controls.Add(numTeams);
            Controls.Add(txtSeason);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(txtCompetitionName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddCompetitionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numTeams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numTeams;
        private TextBox txtSeason;
        private Button btnOK;
        private Button btnCancel;
        private TextBox txtCompetitionName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbType;
        private ComboBox cbStatus;
    }
}