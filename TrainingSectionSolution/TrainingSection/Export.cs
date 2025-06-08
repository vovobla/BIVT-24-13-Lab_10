using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Model.Core;
using Model.Data;

namespace TrainingSection
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
            this.Load += Export_Load;
        }

        private void Export_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;

            comboBoxFormat.Items.Clear();
            comboBoxFormat.Items.AddRange(new[] { "JSON", "XML" });
            comboBoxFormat.SelectedIndex = 0;

            StyleButton(buttonExport);
            StyleButton(buttonBack);

            buttonExport.Paint += RoundPaint;
            buttonBack.Paint += RoundPaint;

            buttonExport.Click += ButtonExport_Click;
            buttonBack.Click += (s, args) =>
            {
                this.Owner?.Show();
                this.Close();
            };
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            string format = comboBoxFormat.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(format)) return;

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = format == "JSON"
                ? "JSON файлы (*.json)|*.json"
                : "XML файлы (*.xml)|*.xml";
            saveDialog.Title = "Сохранить отчет";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (format == "JSON")
                    {
                        var serializer = new JsonSerializer();
                        serializer.Serialize(saveDialog.FileName, Program.Trainers);
                    }
                    else
                    {
                        var serializer = new XmlSerializer();
                        var dtos = XmlSerializer.ConvertToDTO(Program.Trainers);
                        serializer.Serialize(saveDialog.FileName, dtos);
                    }

                    MessageBox.Show("Отчёт успешно сохранён!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
