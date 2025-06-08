using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace TrainingSection
{
    public partial class Hello_form : Form
    {
        public Hello_form()
        {
            InitializeComponent();
            this.BackColor = Color.LightSkyBlue;
            panelHeader.BackColor = Color.MidnightBlue;
            labelTitle.ForeColor = Color.White;
            labelTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            ApplyRoundedStyle(buttonOpenGroupEditor);
            ApplyRoundedStyle(buttonOpenTrainerInfo);
            ApplyRoundedStyle(buttonOpenTrainerRatings);
            ApplyRoundedStyle(buttonOpenFilters);

            this.BackColor = Color.LightSkyBlue; // светло-голубой фон
            
        }
        private void ApplyRoundedStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.White;
            button.ForeColor = Color.MidnightBlue;
            button.Paint += RoundPaint;
        }

        private void RoundPaint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int radius = 20;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            btn.Region = new Region(path);
        }

        private void buttonOpenGroupEditor_Click(object sender, EventArgs e)
        {
            var form = new Groups();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();
        }

        private void buttonOpenTrainerInfo_Click(object sender, EventArgs e)
        {
            var form = new Trainers();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();
        }

        private void buttonOpenTrainerRatings_Click(object sender, EventArgs e)
        {
            var form = new Rank();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();
        }

        private void buttonOpenFilters_Click(object sender, EventArgs e)
        {
            var form = new Filters();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();
        }
    }
}
