using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Model.Core;

namespace TrainingSection
{
    public partial class Trainers : Form
    {
        public Trainers()
        {
            InitializeComponent();
            this.Load += Trainers_Load;
            this.BackColor = Color.LightSkyBlue;
        }

        private void Trainers_Load(object sender, EventArgs e)
        {
            comboBoxTrainerStats.DataSource = Program.Trainers.ToList();
            comboBoxTrainerStats.DisplayMember = "FullName";
            comboBoxTrainerStats.SelectedIndex = -1;
            comboBoxTrainerStats.Text = "Тренер";
            comboBoxTrainerStats.SelectedIndexChanged += ComboBoxTrainerStats_SelectedIndexChanged;

            dataGridViewTrainerStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTrainerStats.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewTrainerStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewTrainerStats.BackgroundColor = Color.AliceBlue;
            dataGridViewTrainerStats.DefaultCellStyle.BackColor = Color.White;
            dataGridViewTrainerStats.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewTrainerStats.EnableHeadersVisualStyles = false;
            dataGridViewTrainerStats.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridViewTrainerStats.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.BackColor = Color.White;
            buttonBack.ForeColor = Color.MidnightBlue;
            buttonBack.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonBack.Click += ButtonBack_Click;
            buttonBack.Paint += RoundPaint;
        }


        private void RoundPaint(object sender, PaintEventArgs e)
        {
            if (sender is Button btn)
            {
                int radius = 15;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                btn.Region = new Region(path);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Close();
        }

        private void ComboBoxTrainerStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trainer = comboBoxTrainerStats.SelectedItem as Trainer;
            if (trainer == null) return;

            var data = trainer.Groups.Select(g =>
            {
                var count = g.Athletes.Count;
                double male = count > 0 ? g.Athletes.Count(a => a.Gender == Gender.Male) * 100.0 / count : 0;
                double female = count > 0 ? g.Athletes.Count(a => a.Gender == Gender.Female) * 100.0 / count : 0;
                double avg = count > 0 ? g.Athletes.Average(a => a.Age) : 0;
                double med = count > 0 ? Median(g.Athletes.Select(a => a.Age).ToList()) : 0;

                return new
                {
                    Группа = g.Name,
                    Участников = count,
                    Мужчины = Math.Round(male, 1) + "%",
                    Женщины = Math.Round(female, 1) + "%",
                    СреднийВозраст = Math.Round(avg, 1),
                    МедианныйВозраст = med
                };
            }).ToList();

            dataGridViewTrainerStats.DataSource = data;
            dataGridViewTrainerStats.ReadOnly = true;

            if (dataGridViewTrainerStats.Columns.Contains("СреднийВозраст"))
                dataGridViewTrainerStats.Columns["СреднийВозраст"].HeaderText = "Средний возраст";

            if (dataGridViewTrainerStats.Columns.Contains("МедианныйВозраст"))
                dataGridViewTrainerStats.Columns["МедианныйВозраст"].HeaderText = "Медианный возраст";

            dataGridViewTrainerStats.AutoResizeColumns();
            dataGridViewTrainerStats.AutoResizeColumnHeadersHeight();
        }

        private double Median(List<int> list)
        {
            if (list.Count == 0) return 0;
            var sorted = list.OrderBy(n => n).ToList();
            int mid = sorted.Count / 2;
            return sorted.Count % 2 == 0
                ? (sorted[mid - 1] + sorted[mid]) / 2.0
                : sorted[mid];
        }
    }
}
