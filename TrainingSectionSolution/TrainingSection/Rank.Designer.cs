using System.Drawing;
using System.Windows.Forms;

namespace TrainingSection
{
    partial class Rank
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboBoxAthletes;
        private ComboBox comboBoxGroups;
        private NumericUpDown numericUpDownRating;
        private Button buttonFeedback;
        private Button buttonBack;
        private DataGridView dataGridViewTrainers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rank));
            comboBoxAthletes = new ComboBox();
            comboBoxGroups = new ComboBox();
            numericUpDownRating = new NumericUpDown();
            buttonFeedback = new Button();
            buttonBack = new Button();
            dataGridViewTrainers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainers).BeginInit();
            SuspendLayout();
            // 
            // comboBoxAthletes
            // 
            comboBoxAthletes.Location = new Point(30, 20);
            comboBoxAthletes.Name = "comboBoxAthletes";
            comboBoxAthletes.Size = new Size(200, 28);
            comboBoxAthletes.TabIndex = 0;
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.Location = new Point(250, 20);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(200, 28);
            comboBoxGroups.TabIndex = 1;
            // 
            // numericUpDownRating
            // 
            numericUpDownRating.Location = new Point(470, 20);
            numericUpDownRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRating.Name = "numericUpDownRating";
            numericUpDownRating.Size = new Size(60, 27);
            numericUpDownRating.TabIndex = 2;
            numericUpDownRating.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // buttonFeedback
            // 
            buttonFeedback.Location = new Point(550, 20);
            buttonFeedback.Name = "buttonFeedback";
            buttonFeedback.Size = new Size(120, 28);
            buttonFeedback.TabIndex = 3;
            buttonFeedback.Text = "Оценка";
            buttonFeedback.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(650, 340);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 35);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTrainers
            // 
            dataGridViewTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTrainers.BackgroundColor = Color.AliceBlue;
            dataGridViewTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewTrainers.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTrainers.Location = new Point(30, 70);
            dataGridViewTrainers.Name = "dataGridViewTrainers";
            dataGridViewTrainers.ReadOnly = true;
            dataGridViewTrainers.RowHeadersWidth = 51;
            dataGridViewTrainers.Size = new Size(720, 250);
            dataGridViewTrainers.TabIndex = 5;
            // 
            // Rank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 400);
            Controls.Add(comboBoxAthletes);
            Controls.Add(comboBoxGroups);
            Controls.Add(numericUpDownRating);
            Controls.Add(buttonFeedback);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewTrainers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rank";
            Text = "Рейтинги тренеров";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainers).EndInit();
            ResumeLayout(false);
        }
    }
}
