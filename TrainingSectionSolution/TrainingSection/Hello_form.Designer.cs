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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonOpenGroupEditor = new System.Windows.Forms.Button();
            this.buttonOpenTrainerInfo = new System.Windows.Forms.Button();
            this.buttonOpenTrainerRatings = new System.Windows.Forms.Button();
            this.buttonOpenFilters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Location = new System.Drawing.Point(50, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(500, 60);
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Text = "Добро пожаловать в сервис для сбора статистики\nэффективности работы тренеров";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOpenGroupEditor
            // 
            this.buttonOpenGroupEditor.Location = new System.Drawing.Point(175, 100);
            this.buttonOpenGroupEditor.Name = "buttonOpenGroupEditor";
            this.buttonOpenGroupEditor.Size = new System.Drawing.Size(250, 40);
            this.buttonOpenGroupEditor.TabIndex = 0;
            this.buttonOpenGroupEditor.Text = "Редактирование групп";
            this.buttonOpenGroupEditor.UseVisualStyleBackColor = true;
            this.buttonOpenGroupEditor.Click += new System.EventHandler(this.buttonOpenGroupEditor_Click);
            // 
            // buttonOpenTrainerInfo
            // 
            this.buttonOpenTrainerInfo.Location = new System.Drawing.Point(175, 160);
            this.buttonOpenTrainerInfo.Name = "buttonOpenTrainerInfo";
            this.buttonOpenTrainerInfo.Size = new System.Drawing.Size(250, 40);
            this.buttonOpenTrainerInfo.TabIndex = 1;
            this.buttonOpenTrainerInfo.Text = "Тренеры и фидбек";
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
            // buttonOpenFilters
            // 
            this.buttonOpenFilters.Location = new System.Drawing.Point(175, 280);
            this.buttonOpenFilters.Name = "buttonOpenFilters";
            this.buttonOpenFilters.Size = new System.Drawing.Size(250, 40);
            this.buttonOpenFilters.TabIndex = 3;
            this.buttonOpenFilters.Text = "Фильтры";
            this.buttonOpenFilters.UseVisualStyleBackColor = true;
            this.buttonOpenFilters.Click += new System.EventHandler(this.buttonOpenFilters_Click);
            // 
            // Hello_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonOpenGroupEditor);
            this.Controls.Add(this.buttonOpenTrainerInfo);
            this.Controls.Add(this.buttonOpenTrainerRatings);
            this.Controls.Add(this.buttonOpenFilters);
            this.Name = "Hello_form";
            this.Text = "TrainingSection";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonOpenGroupEditor;
        private System.Windows.Forms.Button buttonOpenTrainerInfo;
        private System.Windows.Forms.Button buttonOpenTrainerRatings;
        private System.Windows.Forms.Button buttonOpenFilters;
    }
}
