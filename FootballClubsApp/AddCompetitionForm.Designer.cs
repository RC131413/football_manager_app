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
            txtSeason = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            txtCompetitionName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSeason
            // 
            txtSeason.Location = new Point(300, 141);
            txtSeason.Name = "txtSeason";
            txtSeason.Size = new Size(100, 23);
            txtSeason.TabIndex = 37;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(342, 193);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 35;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(423, 193);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(300, 115);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 30;
            label3.Text = "Sezon";
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
            // AddCompetitionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 401);
            Controls.Add(txtSeason);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(txtCompetitionName);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddCompetitionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSeason;
        private Button btnOK;
        private Button btnCancel;
        private TextBox txtCompetitionName;
        private Label label3;
        private Label label1;
    }
}