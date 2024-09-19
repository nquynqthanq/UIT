namespace GUI
{
    partial class FarmForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddAnimals;
        private Button btnMakeSounds;
        private Button btnGetStatistics;
        private Button btnClearAnimals;
        private TextBox txtCowCount;
        private TextBox txtSheepCount;
        private TextBox txtGoatCount;
        private Label lblCowCount;
        private Label lblSheepCount;
        private Label lblGoatCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddAnimals = new Button();
            btnMakeSounds = new Button();
            btnGetStatistics = new Button();
            btnClearAnimals = new Button();
            txtCowCount = new TextBox();
            txtSheepCount = new TextBox();
            txtGoatCount = new TextBox();
            lblCowCount = new Label();
            lblSheepCount = new Label();
            lblGoatCount = new Label();
            SuspendLayout();
            // 
            // btnAddAnimals
            // 
            btnAddAnimals.Location = new Point(12, 181);
            btnAddAnimals.Name = "btnAddAnimals";
            btnAddAnimals.Size = new Size(120, 30);
            btnAddAnimals.TabIndex = 0;
            btnAddAnimals.Text = "Thêm Gia Súc";
            btnAddAnimals.UseVisualStyleBackColor = true;
            btnAddAnimals.Click += btnAddAnimals_Click;
            // 
            // btnMakeSounds
            // 
            btnMakeSounds.Location = new Point(138, 181);
            btnMakeSounds.Name = "btnMakeSounds";
            btnMakeSounds.Size = new Size(120, 30);
            btnMakeSounds.TabIndex = 1;
            btnMakeSounds.Text = "Kêu Tiếng";
            btnMakeSounds.UseVisualStyleBackColor = true;
            btnMakeSounds.Click += btnMakeSounds_Click;
            // 
            // btnGetStatistics
            // 
            btnGetStatistics.Location = new Point(264, 181);
            btnGetStatistics.Name = "btnGetStatistics";
            btnGetStatistics.Size = new Size(120, 30);
            btnGetStatistics.TabIndex = 2;
            btnGetStatistics.Text = "Thống Kê";
            btnGetStatistics.UseVisualStyleBackColor = true;
            btnGetStatistics.Click += btnGetStatistics_Click;
            // 
            // btnClearAnimals
            // 
            btnClearAnimals.Location = new Point(390, 181);
            btnClearAnimals.Name = "btnClearAnimals";
            btnClearAnimals.Size = new Size(120, 30);
            btnClearAnimals.TabIndex = 3;
            btnClearAnimals.Text = "Xóa Tất Cả";
            btnClearAnimals.UseVisualStyleBackColor = true;
            btnClearAnimals.Click += btnClearAnimals_Click;
            // 
            // txtCowCount
            // 
            txtCowCount.Location = new Point(230, 43);
            txtCowCount.Name = "txtCowCount";
            txtCowCount.Size = new Size(120, 23);
            txtCowCount.TabIndex = 4;
            // 
            // txtSheepCount
            // 
            txtSheepCount.Location = new Point(230, 80);
            txtSheepCount.Name = "txtSheepCount";
            txtSheepCount.Size = new Size(120, 23);
            txtSheepCount.TabIndex = 5;
            // 
            // txtGoatCount
            // 
            txtGoatCount.Location = new Point(230, 120);
            txtGoatCount.Name = "txtGoatCount";
            txtGoatCount.Size = new Size(120, 23);
            txtGoatCount.TabIndex = 6;
            // 
            // lblCowCount
            // 
            lblCowCount.AutoSize = true;
            lblCowCount.Location = new Point(138, 43);
            lblCowCount.Name = "lblCowCount";
            lblCowCount.Size = new Size(74, 15);
            lblCowCount.TabIndex = 7;
            lblCowCount.Text = "Số lượng bò:";
            // 
            // lblSheepCount
            // 
            lblSheepCount.AutoSize = true;
            lblSheepCount.Location = new Point(138, 83);
            lblSheepCount.Name = "lblSheepCount";
            lblSheepCount.Size = new Size(80, 15);
            lblSheepCount.TabIndex = 8;
            lblSheepCount.Text = "Số lượng cừu:";
            // 
            // lblGoatCount
            // 
            lblGoatCount.AutoSize = true;
            lblGoatCount.Location = new Point(138, 123);
            lblGoatCount.Name = "lblGoatCount";
            lblGoatCount.Size = new Size(73, 15);
            lblGoatCount.TabIndex = 9;
            lblGoatCount.Text = "Số lượng dê:";
            // 
            // FarmForm
            // 
            ClientSize = new Size(529, 244);
            Controls.Add(lblGoatCount);
            Controls.Add(lblSheepCount);
            Controls.Add(lblCowCount);
            Controls.Add(txtGoatCount);
            Controls.Add(txtSheepCount);
            Controls.Add(txtCowCount);
            Controls.Add(btnClearAnimals);
            Controls.Add(btnGetStatistics);
            Controls.Add(btnMakeSounds);
            Controls.Add(btnAddAnimals);
            Name = "FarmForm";
            Text = "Farm Management";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
