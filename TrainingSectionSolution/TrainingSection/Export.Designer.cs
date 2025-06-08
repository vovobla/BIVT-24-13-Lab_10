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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            comboBoxFormat = new ComboBox();
            buttonExport = new Button();
            buttonBack = new Button();
            labelFormat = new Label();
            SuspendLayout();
            // 
            // comboBoxFormat
            // 
            comboBoxFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormat.Location = new Point(220, 60);
            comboBoxFormat.Name = "comboBoxFormat";
            comboBoxFormat.Size = new Size(200, 28);
            comboBoxFormat.TabIndex = 0;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(180, 120);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(180, 40);
            buttonExport.TabIndex = 1;
            buttonExport.Text = "Сохранить отчёт";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(400, 220);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 35);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Назад";
            // 
            // labelFormat
            // 
            labelFormat.Font = new Font("Segoe UI", 10F);
            labelFormat.Location = new Point(70, 60);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new Size(150, 28);
            labelFormat.TabIndex = 0;
            labelFormat.Text = "Выберите формат:";
            // 
            // Export
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 280);
            Controls.Add(labelFormat);
            Controls.Add(comboBoxFormat);
            Controls.Add(buttonExport);
            Controls.Add(buttonBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Export";
            Text = "Экспорт отчёта";
            ResumeLayout(false);
        }
    }
}
