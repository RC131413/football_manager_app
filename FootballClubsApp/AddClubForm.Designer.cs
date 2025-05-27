namespace FootballClubsApp
{
    partial class AddClubForm
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
            btnOK = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpFoundedDate = new DateTimePicker();
            label1 = new Label();
            txtCity = new TextBox();
            txtStadium = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(344, 325);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 23;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(425, 325);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(300, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(300, 240);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 18;
            label5.Text = "Data założenia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(300, 172);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 16;
            label3.Text = "Stadion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(300, 115);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 14;
            label2.Text = "Miasto";
            // 
            // dtpFoundedDate
            // 
            dtpFoundedDate.Location = new Point(300, 263);
            dtpFoundedDate.Name = "dtpFoundedDate";
            dtpFoundedDate.Size = new Size(200, 23);
            dtpFoundedDate.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(300, 53);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 12;
            label1.Text = "Nazwa klubu";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(300, 138);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 24;
            // 
            // txtStadium
            // 
            txtStadium.Location = new Point(300, 198);
            txtStadium.Name = "txtStadium";
            txtStadium.Size = new Size(100, 23);
            txtStadium.TabIndex = 25;
            // 
            // AddClubForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStadium);
            Controls.Add(txtCity);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFoundedDate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddClubForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtName;
        private Label label5;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFoundedDate;
        private Label label1;
        private TextBox txtCity;
        private TextBox txtStadium;
    }
}