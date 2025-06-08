using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Model.Core;

namespace TrainingSection
{
    public partial class Groups : Form
    {
        public Groups()
        {
            InitializeComponent();
            this.Load += Groups_Load;
            this.BackColor = Color.LightSkyBlue;
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            comboBoxGroups.DataSource = Program.Groups;
            comboBoxGroups.DisplayMember = "Name";
            comboBoxGroups.SelectedIndexChanged += (s, e) => UpdateAthletes();

            comboBoxAthletes.DataSource = Program.AllAthletes;
            comboBoxAthletes.DisplayMember = "FullName";

            comboBoxGenderFilter.Items.AddRange(new string[] { "Все", "Мужчины", "Женщины" });
            comboBoxGenderFilter.SelectedIndex = 0;
            comboBoxGenderFilter.SelectedIndexChanged += (s, e) => ApplyFilters();

            StyleButton(buttonAdd);
            StyleButton(buttonRemove);
            buttonAdd.Click += buttonAddAthlete_Click;
            buttonRemove.Click += buttonRemoveAthlete_Click;
            buttonAdd.Paint += RoundPaint;
            buttonRemove.Paint += RoundPaint;

            numericUpDownMinAge.Minimum = 0;
            numericUpDownMinAge.Maximum = 100;
            numericUpDownMaxAge.Minimum = 0;
            numericUpDownMaxAge.Maximum = 100;
            numericUpDownMaxAge.Value = 100;
            numericUpDownMinAge.ValueChanged += (s, e) => ApplyFilters();
            numericUpDownMaxAge.ValueChanged += (s, e) => ApplyFilters();

            dataGridViewAthletes.BackgroundColor = Color.AliceBlue;
            dataGridViewAthletes.DefaultCellStyle.BackColor = Color.White;
            dataGridViewAthletes.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewAthletes.EnableHeadersVisualStyles = false;
            dataGridViewAthletes.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridViewAthletes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            UpdateAthletes();
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

        private void buttonAddAthlete_Click(object sender, EventArgs e)
        {
            var group = comboBoxGroups.SelectedItem as Group;
            var athlete = comboBoxAthletes.SelectedItem as Athlete;
            if (group != null && athlete != null)
            {
                if (group.Athletes.Contains(athlete))
                {
                    MessageBox.Show($"Спортсмен {athlete.FullName} уже есть в группе.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    group.AddAthlete(athlete);
                    SaveGroup(group);
                    UpdateAthletes();
                    MessageBox.Show($"Спортсмен {athlete.FullName} добавлен в группу.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonRemoveAthlete_Click(object sender, EventArgs e)
        {
            var group = comboBoxGroups.SelectedItem as Group;
            if (group != null && dataGridViewAthletes.CurrentRow != null)
            {
                string fullName = dataGridViewAthletes.CurrentRow.Cells[0].Value?.ToString();
                var athlete = group.Athletes.SingleOrDefault(a => a.FullName == fullName);
                if (athlete != null)
                {
                    group.RemoveAthlete(athlete);
                    SaveGroup(group);
                    UpdateAthletes();
                    MessageBox.Show($"Спортсмен {athlete.FullName} удалён из группы.", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateAthletes()
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var group = comboBoxGroups.SelectedItem as Group;
            if (group == null) return;

            var filtered = group.Athletes.AsEnumerable();

            if (comboBoxGenderFilter.SelectedItem != null)
            {
                string gender = comboBoxGenderFilter.SelectedItem.ToString();
                if (gender == "Мужчины")
                    filtered = filtered.Where(a => a.Gender == Gender.Male);
                else if (gender == "Женщины")
                    filtered = filtered.Where(a => a.Gender == Gender.Female);
            }

            int min = (int)numericUpDownMinAge.Value;
            int max = (int)numericUpDownMaxAge.Value;
            filtered = filtered.Where(a => a.Age >= min && a.Age <= max);

            dataGridViewAthletes.DataSource = null;
            dataGridViewAthletes.DataSource = filtered.Select(a => new
            {
                ФИО = a.FullName,
                Возраст = a.Age,
                Пол = a.Gender == Gender.Male ? "Мужской" : "Женский"
            }).ToList();
        }

        private void SaveGroup(Group group)
        {
            string file = group.Name + ".json";
            Program.Serializer.Serialize(file, group);
        }
    }
}
