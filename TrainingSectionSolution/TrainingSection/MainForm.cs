using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model.Core;
using Model.Data;

namespace TrainingSection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // При загрузке формы выполняется MainForm_Load (можешь инициализировать сразу здесь, если хочешь)
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Заполнение ComboBox группами
            comboBoxGroups.DataSource = Program.Groups;
            comboBoxGroups.DisplayMember = "Name";
            comboBoxGroups.SelectedIndexChanged += comboBoxGroups_SelectedIndexChanged;

            // Заполнение ComboBox тренерами
            comboBoxTrainers.DataSource = Program.Trainers;
            comboBoxTrainers.DisplayMember = "FullName";
            comboBoxTrainers.SelectedIndexChanged += comboBoxTrainers_SelectedIndexChanged;

            // Заполнение ComboBox спортсменами
            comboBoxAthletes.DataSource = Program.AllAthletes;
            comboBoxAthletes.DisplayMember = "FullName";

            // Формат сериализации
            comboBoxFormat.Items.Clear();
            comboBoxFormat.Items.Add("JSON");
            comboBoxFormat.Items.Add("XML");
            comboBoxFormat.SelectedIndex = 0;
            comboBoxFormat.SelectedIndexChanged += comboBoxFormat_SelectedIndexChanged;

            // Значения для numericUpDownRating
            numericUpDownRating.Minimum = 1;
            numericUpDownRating.Maximum = 5;
            numericUpDownRating.Value = 5;

            // Инициализация таблиц
            UpdateAthletes();
            UpdateGroupsOfTrainer();
            UpdateTrainerRatings();
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAthletes();
        }

        private void comboBoxTrainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGroupsOfTrainer();
        }

        private void comboBoxAthletes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ничего не нужно, если только не хочешь подсвечивать текущего спортсмена
        }

        private void buttonAddAthlete_Click(object sender, EventArgs e)
        {
            var group = comboBoxGroups.SelectedItem as Group;
            var athlete = comboBoxAthletes.SelectedItem as Athlete;
            if (group != null && athlete != null)
            {
                group.AddAthlete(athlete);
                UpdateAthletes();
                UpdateGroupsOfTrainer();
                SaveGroup(group);
            }
        }

        private void buttonRemoveAthlete_Click(object sender, EventArgs e)
        {
            var group = comboBoxGroups.SelectedItem as Group;
            if (group != null && dataGridViewAthletes.CurrentRow != null)
            {
                string fullName = dataGridViewAthletes.CurrentRow.Cells[0].Value.ToString();
                var athlete = group.Athletes.FirstOrDefault(a => a.FullName == fullName);
                if (athlete != null)
                {
                    group.RemoveAthlete(athlete);
                    UpdateAthletes();
                    SaveGroup(group);
                    MessageBox.Show($"Спортсмен {athlete.FullName} удалён из группы.");
                }
                else
                {
                    MessageBox.Show("Не удалось найти выбранного спортсмена.");
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите группу и участника в таблице.");
            }
        }

        private void buttonFeedback_Click(object sender, EventArgs e)
        {
            var group = comboBoxGroups.SelectedItem as Group;
            var athlete = comboBoxAthletes.SelectedItem as Athlete;
            int rating = (int)numericUpDownRating.Value;
            if (group != null && athlete != null)
            {
                if (group.CanLeaveFeedback(athlete))
                {
                    group.LeaveFeedback(athlete, rating);
                    UpdateTrainerRatings();
                    SaveGroup(group);
                    MessageBox.Show("Отзыв успешно сохранён!");
                }
                else
                {
                    MessageBox.Show("Этот спортсмен уже оставил отзыв для этой группы!");
                }
            }
        }

        private void comboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormat.SelectedItem?.ToString() == "JSON")
                Program.Serializer = new JsonSerializer();
            else
                Program.Serializer = new XmlSerializer();
        }

        private void buttonExportReport_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (comboBoxFormat.SelectedItem?.ToString() == "JSON")
                saveFileDialog.Filter = "JSON файлы (*.json)|*.json";
            else
                saveFileDialog.Filter = "XML файлы (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Program.Serializer.Serialize(saveFileDialog.FileName, Program.Trainers);
                    MessageBox.Show("Отчёт успешно сохранён!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message);
                }
            }
        }

        // --- СЛУЖЕБНЫЕ МЕТОДЫ ДЛЯ ОБНОВЛЕНИЯ ТАБЛИЦ И ДАННЫХ ---

        private void UpdateAthletes()
        {
            var group = comboBoxGroups.SelectedItem as Group;
            dataGridViewAthletes.DataSource = null;
            if (group != null)
                dataGridViewAthletes.DataSource = group.Athletes.Select(a => new
                {
                    ФИО = a.FullName,
                    Возраст = a.Age,
                    Пол = a.Gender
                }).ToList();
        }

        private void UpdateGroupsOfTrainer()
        {
            var trainer = comboBoxTrainers.SelectedItem as Trainer;
            dataGridViewGroupsOfTrainer.DataSource = null;
            if (trainer != null)
                dataGridViewGroupsOfTrainer.DataSource = trainer.Groups.Select(g => new
                {
                    Группа = g.Name,
                    Количество_участников = g.Athletes.Count,
                    Мужчин = g.Athletes.Count(a => a.Gender == Gender.Male),
                    Женщин = g.Athletes.Count(a => a.Gender == Gender.Female),
                    Средний_возраст = g.Athletes.Count > 0 ? g.Athletes.Average(a => a.Age) : 0
                }).ToList();
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

        private void SaveGroup(Group group)
        {
            string file = $"{group.Name}.{(comboBoxFormat.SelectedItem?.ToString() == "XML" ? "xml" : "json")}";
            Program.Serializer.Serialize(file, group);
        }
        private void dataGridViewTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void numericUpDownRating_ValueChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void z(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}