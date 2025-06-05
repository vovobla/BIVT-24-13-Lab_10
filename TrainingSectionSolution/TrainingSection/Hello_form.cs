using System;
using System.Windows.Forms;

namespace TrainingSection
{
    public partial class Hello_form : Form
    {
        public Hello_form()
        {
            InitializeComponent();
        }

        private void buttonOpenGroupEditor_Click(object sender, EventArgs e)
        {
            var form = new MainForm();
            form.FormClosed += (s, args) => this.Show(); 
            form.Show();
            this.Hide();
        }

        private void buttonOpenTrainerInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет окно с информацией о тренерах и фидбеке.");
        }

        private void buttonOpenTrainerRatings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет таблица рейтингов тренеров.");
        }

        private void buttonOpenFilters_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь будет окно с фильтрами и сортировкой.");
        }
    }
}
