namespace FootballClubsApp
{
    partial class MatchEventsForm
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
            lblHeader = new Label();
            btnAddEvent = new Button();
            dgvEvents = new DataGridView();
            Minute = new DataGridViewTextBoxColumn();
            Player = new DataGridViewTextBoxColumn();
            EventType = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(109, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Zdarzenia";
            // 
            // btnAddEvent
            // 
            btnAddEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddEvent.Location = new Point(543, 0);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(147, 30);
            btnAddEvent.TabIndex = 1;
            btnAddEvent.Text = "Dodaj zdarzenie";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // dgvEvents
            // 
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Columns.AddRange(new DataGridViewColumn[] { Minute, Player, EventType });
            dgvEvents.Dock = DockStyle.Fill;
            dgvEvents.Location = new Point(0, 30);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.Size = new Size(689, 420);
            dgvEvents.TabIndex = 2;
            // 
            // Minute
            // 
            Minute.HeaderText = "Minuta";
            Minute.Name = "Minute";
            // 
            // Player
            // 
            Player.HeaderText = "Zawodnik";
            Player.Name = "Player";
            // 
            // EventType
            // 
            EventType.HeaderText = "Typ zdarzenia";
            EventType.Name = "EventType";
            // 
            // MatchEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 450);
            Controls.Add(dgvEvents);
            Controls.Add(btnAddEvent);
            Controls.Add(lblHeader);
            Name = "MatchEventsForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnAddEvent;
        private DataGridView dgvEvents;
        private DataGridViewTextBoxColumn Minute;
        private DataGridViewTextBoxColumn Player;
        private DataGridViewTextBoxColumn EventType;
    }
}