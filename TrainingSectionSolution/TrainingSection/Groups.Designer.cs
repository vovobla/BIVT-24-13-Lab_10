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
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.comboBoxAthletes = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxGenderFilter = new System.Windows.Forms.ComboBox();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewAthletes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAthletes)).BeginInit();
            this.SuspendLayout();

            // comboBoxGroups
            this.comboBoxGroups.Location = new System.Drawing.Point(30, 30);
            this.comboBoxGroups.Size = new System.Drawing.Size(200, 28);
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // comboBoxAthletes
            this.comboBoxAthletes.Location = new System.Drawing.Point(250, 30);
            this.comboBoxAthletes.Size = new System.Drawing.Size(200, 28);

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(470, 30);
            this.buttonAdd.Size = new System.Drawing.Size(120, 28);
            this.buttonAdd.Text = "Добавить";

            // buttonRemove
            this.buttonRemove.Location = new System.Drawing.Point(600, 30);
            this.buttonRemove.Size = new System.Drawing.Size(120, 28);
            this.buttonRemove.Text = "Удалить";

            // comboBoxGenderFilter
            this.comboBoxGenderFilter.Location = new System.Drawing.Point(30, 70);
            this.comboBoxGenderFilter.Size = new System.Drawing.Size(150, 28);

            // numericUpDownMinAge
            this.numericUpDownMinAge.Location = new System.Drawing.Point(200, 70);
            this.numericUpDownMinAge.Size = new System.Drawing.Size(60, 28);

            // numericUpDownMaxAge
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(270, 70);
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(60, 28);

            // dataGridViewAthletes
            this.dataGridViewAthletes.Location = new System.Drawing.Point(30, 120);
            this.dataGridViewAthletes.Size = new System.Drawing.Size(690, 300);
            this.dataGridViewAthletes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Groups
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.comboBoxAthletes);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.comboBoxGenderFilter);
            this.Controls.Add(this.numericUpDownMinAge);
            this.Controls.Add(this.numericUpDownMaxAge);
            this.Controls.Add(this.dataGridViewAthletes);
            this.Name = "Groups";
            this.Text = "Управление группами";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAthletes)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
