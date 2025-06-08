using System.Drawing;
using System.Windows.Forms;

namespace TrainingSection
{
    partial class Export
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxFormat;
        private Button buttonExport;
        private Button buttonBack;
        private Label labelFormat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxFormat = new ComboBox();
            this.buttonExport = new Button();
            this.buttonBack = new Button();
            this.labelFormat = new Label();

            this.SuspendLayout();

            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxFormat.Location = new Point(220, 60);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new Size(200, 28);
            this.comboBoxFormat.TabIndex = 0;

            // 
            // labelFormat
            // 
            this.labelFormat.Text = "Выберите формат:";
            this.labelFormat.Location = new Point(70, 60);
            this.labelFormat.Size = new Size(150, 28);
            this.labelFormat.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // 
            // buttonExport
            // 
            this.buttonExport.Text = "Сохранить отчёт";
            this.buttonExport.Location = new Point(180, 120);
            this.buttonExport.Size = new Size(180, 40);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.TabIndex = 1;

            // 
            // buttonBack
            // 
            this.buttonBack.Text = "Назад";
            this.buttonBack.Location = new Point(400, 220);
            this.buttonBack.Size = new Size(100, 35);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.TabIndex = 2;

            // 
            // Export
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(540, 280);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonBack);
            this.Name = "Export";
            this.Text = "Экспорт отчёта";
            this.ResumeLayout(false);
        }
    }
}
