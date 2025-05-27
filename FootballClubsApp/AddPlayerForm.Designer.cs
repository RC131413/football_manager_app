namespace FootballClubsApp
{
    partial class AddPlayerForm
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblClub = new Label();
            dgvClubs = new DataGridView();
            lblPosition = new Label();
            lblNumber = new Label();
            lblSelectedClub = new Label();
            txtPosition = new TextBox();
            txtNumber = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            lblLastName = new Label();
            txtLastName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblFirstName.Location = new Point(307, 9);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(40, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Imie";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(307, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblClub.Location = new Point(307, 135);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(41, 20);
            lblClub.TabIndex = 2;
            lblClub.Text = "Klub";
            // 
            // dgvClubs
            // 
            dgvClubs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClubs.Location = new Point(229, 158);
            dgvClubs.Name = "dgvClubs";
            dgvClubs.Size = new Size(273, 150);
            dgvClubs.TabIndex = 3;
            dgvClubs.CellClick += dgvClubs_CellClick;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblPosition.Location = new Point(307, 383);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(61, 20);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Pozycja";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNumber.Location = new Point(307, 436);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(58, 20);
            lblNumber.TabIndex = 5;
            lblNumber.Text = "Numer";
            // 
            // lblSelectedClub
            // 
            lblSelectedClub.AutoSize = true;
            lblSelectedClub.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSelectedClub.Location = new Point(310, 338);
            lblSelectedClub.Name = "lblSelectedClub";
            lblSelectedClub.Size = new Size(106, 20);
            lblSelectedClub.TabIndex = 6;
            lblSelectedClub.Text = "Wybrany klub";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(310, 406);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(100, 23);
            txtPosition.TabIndex = 7;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(310, 459);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 8;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(341, 503);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 9;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(427, 503);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblLastName.Location = new Point(307, 70);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(76, 20);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Nazwisko";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(307, 93);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 12;
            // 
            // AddPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 546);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtNumber);
            Controls.Add(txtPosition);
            Controls.Add(lblSelectedClub);
            Controls.Add(lblNumber);
            Controls.Add(lblPosition);
            Controls.Add(dgvClubs);
            Controls.Add(lblClub);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "AddPlayerForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClubs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblClub;
        private DataGridView dgvClubs;
        private Label lblPosition;
        private Label lblNumber;
        private Label lblSelectedClub;
        private TextBox txtPosition;
        private TextBox txtNumber;
        private Button btnOK;
        private Button btnCancel;
        private Label lblLastName;
        private TextBox txtLastName;
    }
}