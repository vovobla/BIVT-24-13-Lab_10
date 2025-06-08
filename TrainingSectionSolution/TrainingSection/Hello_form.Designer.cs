namespace TrainingSection
{
    partial class Hello_form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello_form));
            panelHeader = new Panel();
            labelTitle = new Label();
            buttonOpenGroupEditor = new Button();
            buttonOpenTrainerInfo = new Button();
            buttonOpenTrainerRatings = new Button();
            buttonOpenFilters = new Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.MidnightBlue;
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(750, 92);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(750, 92);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Training Section";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOpenGroupEditor
            // 
            buttonOpenGroupEditor.Location = new Point(219, 115);
            buttonOpenGroupEditor.Margin = new Padding(4, 3, 4, 3);
            buttonOpenGroupEditor.Name = "buttonOpenGroupEditor";
            buttonOpenGroupEditor.Size = new Size(312, 46);
            buttonOpenGroupEditor.TabIndex = 0;
            buttonOpenGroupEditor.Text = "Группы";
            buttonOpenGroupEditor.UseVisualStyleBackColor = true;
            buttonOpenGroupEditor.Click += buttonOpenGroupEditor_Click;
            // 
            // buttonOpenTrainerInfo
            // 
            buttonOpenTrainerInfo.Location = new Point(219, 184);
            buttonOpenTrainerInfo.Margin = new Padding(4, 3, 4, 3);
            buttonOpenTrainerInfo.Name = "buttonOpenTrainerInfo";
            buttonOpenTrainerInfo.Size = new Size(312, 46);
            buttonOpenTrainerInfo.TabIndex = 1;
            buttonOpenTrainerInfo.Text = "Тренеры";
            buttonOpenTrainerInfo.UseVisualStyleBackColor = true;
            buttonOpenTrainerInfo.Click += buttonOpenTrainerInfo_Click;
            // 
            // buttonOpenTrainerRatings
            // 
            buttonOpenTrainerRatings.Location = new Point(219, 253);
            buttonOpenTrainerRatings.Margin = new Padding(4, 3, 4, 3);
            buttonOpenTrainerRatings.Name = "buttonOpenTrainerRatings";
            buttonOpenTrainerRatings.Size = new Size(312, 46);
            buttonOpenTrainerRatings.TabIndex = 2;
            buttonOpenTrainerRatings.Text = "Рейтинги тренеров";
            buttonOpenTrainerRatings.UseVisualStyleBackColor = true;
            buttonOpenTrainerRatings.Click += buttonOpenTrainerRatings_Click;
            // 
            // buttonOpenFilters
            // 
            buttonOpenFilters.Location = new Point(219, 322);
            buttonOpenFilters.Margin = new Padding(4, 3, 4, 3);
            buttonOpenFilters.Name = "buttonOpenFilters";
            buttonOpenFilters.Size = new Size(312, 46);
            buttonOpenFilters.TabIndex = 3;
            buttonOpenFilters.Text = "Отчет по тренерам";
            buttonOpenFilters.UseVisualStyleBackColor = true;
            buttonOpenFilters.Click += buttonOpenExport_Click;
            // 
            // Hello_form
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(750, 460);
            Controls.Add(panelHeader);
            Controls.Add(buttonOpenGroupEditor);
            Controls.Add(buttonOpenTrainerInfo);
            Controls.Add(buttonOpenTrainerRatings);
            Controls.Add(buttonOpenFilters);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Hello_form";
            Text = "TrainingSection";
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonOpenGroupEditor;
        private System.Windows.Forms.Button buttonOpenTrainerInfo;
        private System.Windows.Forms.Button buttonOpenTrainerRatings;
        private System.Windows.Forms.Button buttonOpenFilters;
    }
}
