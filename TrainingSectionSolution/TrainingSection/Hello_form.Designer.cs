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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonOpenGroupEditor = new System.Windows.Forms.Button();
            this.buttonOpenTrainerInfo = new System.Windows.Forms.Button();
            this.buttonOpenTrainerRatings = new System.Windows.Forms.Button();
            this.buttonOpenFilters = new System.Windows.Forms.Button();
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 80;
            this.panelHeader.Controls.Add(this.labelTitle);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Text = "Training Section";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOpenGroupEditor
            // 
            this.buttonOpenGroupEditor.Location = new System.Drawing.Point(175, 100);
            this.buttonOpenGroupEditor.Name = "buttonOpenGroupEditor";
            this.buttonOpenGroupEditor.Size = new System.Drawing.Size(250, 40);
            this.buttonOpenGroupEditor.TabIndex = 0;
            this.buttonOpenGroupEditor.Text = "Группы";
            this.buttonOpenGroupEditor.UseVisualStyleBackColor = true;
            this.buttonOpenGroupEditor.Click += new System.EventHandler(this.buttonOpenGroupEditor_Click);
            // 
            // buttonOpenTrainerInfo
            // 
            this.buttonOpenTrainerInfo.Location = new System.Drawing.Point(175, 160);
            this.buttonOpenTrainerInfo.Name = "buttonOpenTrainerInfo";
            this.buttonOpenTrainerInfo.Size = new System.Drawing.Size(250, 40);
            this.buttonOpenTrainerInfo.TabIndex = 1;
            this.buttonOpenTrainerInfo.Text = "Тренеры";
            this.buttonOpenTrainerInfo.UseVisualStyleBackColor = true;
            this.buttonOpenTrainerInfo.Click += new System.EventHandler(this.buttonOpenTrainerInfo_Click);
            // 
            // buttonOpenTrainerRatings
            // 
            this.buttonOpenTrainerRatings.Location = new System.Drawing.Point(175, 220);
            this.buttonOpenTrainerRatings.Name = "buttonOpenTrainerRatings";
            this.buttonOpenTrainerRatings.Size = new System.Drawing.Size(250, 40);
            this.buttonOpenTrainerRatings.TabIndex = 2;
            this.buttonOpenTrainerRatings.Text = "Рейтинги тренеров";
            this.buttonOpenTrainerRatings.UseVisualStyleBackColor = true;
            this.buttonOpenTrainerRatings.Click += new System.EventHandler(this.buttonOpenTrainerRatings_Click);
            // 
            // buttonOpenExport
            // 
            this.buttonOpenFilters.Location = new System.Drawing.Point(175, 280);
            this.buttonOpenFilters.Name = "buttonOpenFilters";
            this.buttonOpenFilters.Size = new System.Drawing.Size(250, 40);
            this.buttonOpenFilters.TabIndex = 3;
            this.buttonOpenFilters.Text = "Отчет по тренерам";
            this.buttonOpenFilters.UseVisualStyleBackColor = true;
            this.buttonOpenFilters.Click += new System.EventHandler(this.buttonOpenExport_Click);
            // 
            // Hello_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonOpenGroupEditor);
            this.Controls.Add(this.buttonOpenTrainerInfo);
            this.Controls.Add(this.buttonOpenTrainerRatings);
            this.Controls.Add(this.buttonOpenFilters);
            this.Name = "Hello_form";
            this.Text = "TrainingSection";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
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
