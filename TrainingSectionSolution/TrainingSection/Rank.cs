using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Model.Core;

namespace TrainingSection
{
    public partial class Rank : Form
    {
        public Rank()
        {
            InitializeComponent();
            this.Load += Rank_Load;
            this.BackColor = Color.LightSkyBlue;
        }

        private void Rank_Load(object sender, EventArgs e)
        {
            comboBoxAthletes.DataSource = Program.AllAthletes.ToList();
            comboBoxAthletes.DisplayMember = "FullName";
            comboBoxAthletes.SelectedIndex = -1;
            comboBoxAthletes.Text = "Спортсмен";
            comboBoxAthletes.SelectedIndexChanged += ComboBoxAthletes_SelectedIndexChanged;

            comboBoxGroups.Enabled = false;
            comboBoxGroups.SelectedIndexChanged += ComboBoxGroups_SelectedIndexChanged;

            numericUpDownRating.Minimum = 1;
            numericUpDownRating.Maximum = 5;
            numericUpDownRating.Value = 5;

            buttonFeedback.Enabled = false;
            buttonFeedback.Click += ButtonFeedback_Click;
            StyleButton(buttonFeedback);
            buttonFeedback.Paint += RoundPaint;

            StyleButton(buttonBack);
            buttonBack.Click += (s, e) => { this.Owner?.Show(); this.Close(); };
            buttonBack.Paint += RoundPaint;

            UpdateTrainerRatings();
        }

        private void ComboBoxAthletes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGroups.DataSource = null;
            comboBoxGroups.Items.Clear();

            var athlete = comboBoxAthletes.SelectedItem as Athlete;
            if (athlete != null)
            {
                comboBoxGroups.Enabled = true;
                comboBoxGroups.DataSource = Program.Groups;
                comboBoxGroups.DisplayMember = "Name";
            }
            else
            {
                comboBoxGroups.Enabled = false;
                buttonFeedback.Enabled = false;
            }
        }

        private void ComboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonFeedback.Enabled = comboBoxGroups.SelectedItem is Group;
        }

        private void ButtonFeedback_Click(object sender, EventArgs e)
        {
            var group = comboBoxGroups.SelectedItem as Group;
            var athlete = comboBoxAthletes.SelectedItem as Athlete;
            int rating = (int)numericUpDownRating.Value;

            if (group != null && athlete != null)
            {
                if (group.CanLeaveFeedback(athlete))
                {
                    group.LeaveFeedback(athlete, rating);
                    MessageBox.Show("Отзыв успешно сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateTrainerRatings();
                }
                else
                {
                    MessageBox.Show("Этот спортсмен уже оставил отзыв для этой группы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void UpdateTrainerRatings()
        {
            dataGridViewTrainers.DataSource = null;
            dataGridViewTrainers.DataSource = Program.Trainers.Select(t => new
            {
                ФИО = t.FullName,
                Рейтинг = t.Rating,
                Групп = t.Groups.Count
            }).ToList();
        }

        private void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.White;
            button.ForeColor = Color.MidnightBlue;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void RoundPaint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
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
}
