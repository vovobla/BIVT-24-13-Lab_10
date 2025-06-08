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
            buttonBack.Click += (s, args) => { this.Owner?.Show(); this.Close(); };
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            var format = comboBoxFormat.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(format)) return;

            AbstractSerializer newSerializer = format == "XML" ? new XmlSerializer() : new JsonSerializer();
            string newExt = format.ToLower();
            string oldExt = newExt == "json" ? "xml" : "json";

            foreach (var trainer in Program.Trainers)
            {
                string oldFile = trainer.FullName + "." + oldExt;
                string newFile = trainer.FullName + "." + newExt;

                if (File.Exists(oldFile))
                {
                    var serializer = oldExt == "json" ? (AbstractSerializer)new JsonSerializer() : new XmlSerializer();
                    try
                    {
                        var obj = serializer.Deserialize<Trainer>(oldFile);
                        if (obj != null)
                        {
                            newSerializer.Serialize(newFile, obj);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при конвертации {oldFile}: {ex.Message}");
                    }
                }
            }

            MessageBox.Show("Конвертация завершена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
