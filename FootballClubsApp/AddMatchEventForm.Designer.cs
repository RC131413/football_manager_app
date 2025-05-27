namespace FootballClubsApp
{
    partial class AddMatchEventForm
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
            lblMinute = new Label();
            numMinute = new NumericUpDown();
            dgvPlayers = new DataGridView();
            lblSelectedPlayer = new Label();
            cbEventType = new ComboBox();
            lblEventType = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
            SuspendLayout();
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblMinute.Location = new Point(277, 20);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(59, 20);
            lblMinute.TabIndex = 0;
            lblMinute.Text = "Minuta";
            // 
            // numMinute
            // 
            numMinute.Location = new Point(277, 43);
            numMinute.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numMinute.Name = "numMinute";
            numMinute.Size = new Size(120, 23);
            numMinute.TabIndex = 1;
            // 
            // dgvPlayers
            // 
            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayers.Location = new Point(186, 91);
            dgvPlayers.Name = "dgvPlayers";
            dgvPlayers.ReadOnly = true;
            dgvPlayers.Size = new Size(317, 178);
            dgvPlayers.TabIndex = 2;
            dgvPlayers.CellClick += dgvPlayers_CellClick;
            // 
            // lblSelectedPlayer
            // 
            lblSelectedPlayer.AutoSize = true;
            lblSelectedPlayer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSelectedPlayer.Location = new Point(277, 283);
            lblSelectedPlayer.Name = "lblSelectedPlayer";
            lblSelectedPlayer.Size = new Size(142, 20);
            lblSelectedPlayer.TabIndex = 3;
            lblSelectedPlayer.Text = "Wybrany zawodnik";
            // 
            // cbEventType
            // 
            cbEventType.FormattingEnabled = true;
            cbEventType.Location = new Point(277, 349);
            cbEventType.Name = "cbEventType";
            cbEventType.Size = new Size(121, 23);
            cbEventType.TabIndex = 5;
            // 
            // lblEventType
            // 
            lblEventType.AutoSize = true;
            lblEventType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblEventType.Location = new Point(277, 326);
            lblEventType.Name = "lblEventType";
            lblEventType.Size = new Size(104, 20);
            lblEventType.TabIndex = 6;
            lblEventType.Text = "Typ zdarzenia";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(344, 392);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(428, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddMatchEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lblEventType);
            Controls.Add(cbEventType);
            Controls.Add(lblSelectedPlayer);
            Controls.Add(dgvPlayers);
            Controls.Add(numMinute);
            Controls.Add(lblMinute);
            Name = "AddMatchEventForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMinute;
        private NumericUpDown numMinute;
        private DataGridView dgvPlayers;
        private Label lblSelectedPlayer;
        private ComboBox cbEventType;
        private Label lblEventType;
        private Button btnOK;
        private Button btnCancel;
    }
}