using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrainingSection
{
    partial class Trainers
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxTrainerStats;
        private DataGridView dataGridViewTrainerStats;
        private Button buttonBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainers));
            comboBoxTrainerStats = new ComboBox();
            dataGridViewTrainerStats = new DataGridView();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainerStats).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTrainerStats
            // 
            comboBoxTrainerStats.Location = new Point(30, 30);
            comboBoxTrainerStats.Name = "comboBoxTrainerStats";
            comboBoxTrainerStats.Size = new Size(400, 28);
            comboBoxTrainerStats.TabIndex = 0;
            // 
            // dataGridViewTrainerStats
            // 
            dataGridViewTrainerStats.ColumnHeadersHeight = 29;
            dataGridViewTrainerStats.Location = new Point(30, 70);
            dataGridViewTrainerStats.Name = "dataGridViewTrainerStats";
            dataGridViewTrainerStats.RowHeadersWidth = 51;
            dataGridViewTrainerStats.Size = new Size(700, 300);
            dataGridViewTrainerStats.TabIndex = 1;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonBack.ForeColor = Color.MidnightBlue;
            buttonBack.Location = new Point(670, 380);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 30);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += ButtonBack_Click;
            // 
            // Trainers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 420);
            Controls.Add(comboBoxTrainerStats);
            Controls.Add(dataGridViewTrainerStats);
            Controls.Add(buttonBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Trainers";
            Text = "Статистика тренеров";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainerStats).EndInit();
            ResumeLayout(false);
        }
    }
}
