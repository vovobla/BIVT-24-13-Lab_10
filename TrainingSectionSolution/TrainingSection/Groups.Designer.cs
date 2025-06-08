namespace TrainingSection
{
    partial class Groups
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.ComboBox comboBoxAthletes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxGenderFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownMinAge;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAge;
        private System.Windows.Forms.DataGridView dataGridViewAthletes;
        private System.Windows.Forms.Label labelAgeFilter;
        private System.Windows.Forms.Label labelMinAge;
        private System.Windows.Forms.Label labelMaxAge;
        private System.Windows.Forms.Button buttonBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            comboBoxGroups = new ComboBox();
            comboBoxAthletes = new ComboBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            comboBoxGenderFilter = new ComboBox();
            numericUpDownMinAge = new NumericUpDown();
            numericUpDownMaxAge = new NumericUpDown();
            labelAgeFilter = new Label();
            labelMinAge = new Label();
            labelMaxAge = new Label();
            dataGridViewAthletes = new DataGridView();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).BeginInit();
            SuspendLayout();
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroups.Location = new Point(30, 30);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(200, 28);
            comboBoxGroups.TabIndex = 0;
            // 
            // comboBoxAthletes
            // 
            comboBoxAthletes.Location = new Point(250, 30);
            comboBoxAthletes.Name = "comboBoxAthletes";
            comboBoxAthletes.Size = new Size(200, 28);
            comboBoxAthletes.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(470, 30);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 28);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(600, 30);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(120, 28);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Удалить";
            // 
            // comboBoxGenderFilter
            // 
            comboBoxGenderFilter.Location = new Point(30, 73);
            comboBoxGenderFilter.Name = "comboBoxGenderFilter";
            comboBoxGenderFilter.Size = new Size(150, 28);
            comboBoxGenderFilter.TabIndex = 4;
            // 
            // numericUpDownMinAge
            // 
            numericUpDownMinAge.Location = new Point(315, 75);
            numericUpDownMinAge.Name = "numericUpDownMinAge";
            numericUpDownMinAge.Size = new Size(60, 27);
            numericUpDownMinAge.TabIndex = 7;
            // 
            // numericUpDownMaxAge
            // 
            numericUpDownMaxAge.Location = new Point(417, 75);
            numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            numericUpDownMaxAge.Size = new Size(60, 27);
            numericUpDownMaxAge.TabIndex = 9;
            numericUpDownMaxAge.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelAgeFilter
            // 
            labelAgeFilter.Font = new Font("Segoe UI", 10F);
            labelAgeFilter.Location = new Point(190, 72);
            labelAgeFilter.Name = "labelAgeFilter";
            labelAgeFilter.Size = new Size(94, 28);
            labelAgeFilter.TabIndex = 5;
            labelAgeFilter.Text = "Возрастом";
            labelAgeFilter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMinAge
            // 
            labelMinAge.Location = new Point(284, 72);
            labelMinAge.Name = "labelMinAge";
            labelMinAge.Size = new Size(30, 28);
            labelMinAge.TabIndex = 6;
            labelMinAge.Text = "от";
            labelMinAge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMaxAge
            // 
            labelMaxAge.Location = new Point(385, 72);
            labelMaxAge.Name = "labelMaxAge";
            labelMaxAge.Size = new Size(32, 28);
            labelMaxAge.TabIndex = 8;
            labelMaxAge.Text = "до";
            labelMaxAge.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewAthletes
            // 
            dataGridViewAthletes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAthletes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAthletes.Location = new Point(30, 120);
            dataGridViewAthletes.Name = "dataGridViewAthletes";
            dataGridViewAthletes.RowHeadersWidth = 51;
            dataGridViewAthletes.Size = new Size(690, 300);
            dataGridViewAthletes.TabIndex = 10;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(600, 435);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(120, 35);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += ButtonBack_Click;
            // 
            // Groups
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 500);
            Controls.Add(comboBoxGroups);
            Controls.Add(comboBoxAthletes);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
            Controls.Add(comboBoxGenderFilter);
            Controls.Add(labelAgeFilter);
            Controls.Add(labelMinAge);
            Controls.Add(numericUpDownMinAge);
            Controls.Add(labelMaxAge);
            Controls.Add(numericUpDownMaxAge);
            Controls.Add(dataGridViewAthletes);
            Controls.Add(buttonBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Groups";
            Text = "Управление группами";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).EndInit();
            ResumeLayout(false);
        }
    }
}
