// Дополненный и завершённый MainForm.Designer.cs
namespace TrainingSection
{
    partial class MainForm
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
            comboBoxGroups = new ComboBox();
            comboBoxTrainers = new ComboBox();
            dataGridViewAthletes = new DataGridView();
            dataGridViewGroupsOfTrainer = new DataGridView();
            comboBoxAthletes = new ComboBox();
            buttonAddAthlete = new Button();
            buttonRemoveAthlete = new Button();
            numericUpDownRating = new NumericUpDown();
            buttonFeedback = new Button();
            dataGridViewTrainers = new DataGridView();
            comboBoxFormat = new ComboBox();
            buttonExportReport = new Button();
            buttonSortByName = new Button();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            buttonFilterGender = new Button();
            numericMinAge = new NumericUpDown();
            numericMaxAge = new NumericUpDown();
            buttonFilterByAge = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroupsOfTrainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMinAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMaxAge).BeginInit();
            SuspendLayout();
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.Location = new Point(10, 20);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(150, 28);
            comboBoxGroups.TabIndex = 0;
            // 
            // comboBoxTrainers
            // 
            comboBoxTrainers.Location = new Point(10, 280);
            comboBoxTrainers.Name = "comboBoxTrainers";
            comboBoxTrainers.Size = new Size(150, 28);
            comboBoxTrainers.TabIndex = 12;
            // 
            // dataGridViewAthletes
            // 
            dataGridViewAthletes.ColumnHeadersHeight = 29;
            dataGridViewAthletes.Location = new Point(10, 60);
            dataGridViewAthletes.Name = "dataGridViewAthletes";
            dataGridViewAthletes.RowHeadersWidth = 51;
            dataGridViewAthletes.Size = new Size(400, 200);
            dataGridViewAthletes.TabIndex = 4;
            // 
            // dataGridViewGroupsOfTrainer
            // 
            dataGridViewGroupsOfTrainer.ColumnHeadersHeight = 29;
            dataGridViewGroupsOfTrainer.Location = new Point(10, 320);
            dataGridViewGroupsOfTrainer.Name = "dataGridViewGroupsOfTrainer";
            dataGridViewGroupsOfTrainer.RowHeadersWidth = 51;
            dataGridViewGroupsOfTrainer.Size = new Size(400, 150);
            dataGridViewGroupsOfTrainer.TabIndex = 13;
            // 
            // comboBoxAthletes
            // 
            comboBoxAthletes.Location = new Point(170, 20);
            comboBoxAthletes.Name = "comboBoxAthletes";
            comboBoxAthletes.Size = new Size(150, 28);
            comboBoxAthletes.TabIndex = 1;
            // 
            // buttonAddAthlete
            // 
            buttonAddAthlete.Location = new Point(330, 20);
            buttonAddAthlete.Name = "buttonAddAthlete";
            buttonAddAthlete.Size = new Size(150, 28);
            buttonAddAthlete.TabIndex = 2;
            buttonAddAthlete.Text = "Добавить в группу";
            buttonAddAthlete.Click += buttonAddAthlete_Click;
            // 
            // buttonRemoveAthlete
            // 
            buttonRemoveAthlete.Location = new Point(490, 20);
            buttonRemoveAthlete.Name = "buttonRemoveAthlete";
            buttonRemoveAthlete.Size = new Size(150, 28);
            buttonRemoveAthlete.TabIndex = 3;
            buttonRemoveAthlete.Text = "Удалить из группы";
            buttonRemoveAthlete.UseVisualStyleBackColor = true;
            buttonRemoveAthlete.Click += buttonRemoveAthlete_Click;
            // 
            // numericUpDownRating
            // 
            numericUpDownRating.Location = new Point(420, 280);
            numericUpDownRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRating.Name = "numericUpDownRating";
            numericUpDownRating.Size = new Size(120, 27);
            numericUpDownRating.TabIndex = 15;
            numericUpDownRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonFeedback
            // 
            buttonFeedback.Location = new Point(420, 310);
            buttonFeedback.Name = "buttonFeedback";
            buttonFeedback.Size = new Size(150, 28);
            buttonFeedback.TabIndex = 16;
            buttonFeedback.Text = "Оставить фидбек";
            buttonFeedback.Click += buttonFeedback_Click;
            // 
            // dataGridViewTrainers
            // 
            dataGridViewTrainers.ColumnHeadersHeight = 29;
            dataGridViewTrainers.Location = new Point(10, 480);
            dataGridViewTrainers.Name = "dataGridViewTrainers";
            dataGridViewTrainers.RowHeadersWidth = 51;
            dataGridViewTrainers.Size = new Size(400, 150);
            dataGridViewTrainers.TabIndex = 14;
            // 
            // comboBoxFormat
            // 
            comboBoxFormat.Location = new Point(420, 350);
            comboBoxFormat.Name = "comboBoxFormat";
            comboBoxFormat.Size = new Size(150, 28);
            comboBoxFormat.TabIndex = 17;
            // 
            // buttonExportReport
            // 
            buttonExportReport.Location = new Point(420, 390);
            buttonExportReport.Name = "buttonExportReport";
            buttonExportReport.Size = new Size(150, 28);
            buttonExportReport.TabIndex = 18;
            buttonExportReport.Text = "Экспорт отчёта";
            buttonExportReport.Click += buttonExportReport_Click;
            // 
            // buttonSortByName
            // 
            buttonSortByName.Location = new Point(420, 60);
            buttonSortByName.Name = "buttonSortByName";
            buttonSortByName.Size = new Size(150, 28);
            buttonSortByName.TabIndex = 5;
            buttonSortByName.Text = "Сортировать по ФИО";
            // 
            // rbMale
            // 
            rbMale.Location = new Point(420, 100);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(104, 24);
            rbMale.TabIndex = 6;
            rbMale.Text = "Мужчины";
            // 
            // rbFemale
            // 
            rbFemale.Location = new Point(420, 130);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(104, 24);
            rbFemale.TabIndex = 7;
            rbFemale.Text = "Женщины";
            // 
            // buttonFilterGender
            // 
            buttonFilterGender.Location = new Point(420, 160);
            buttonFilterGender.Name = "buttonFilterGender";
            buttonFilterGender.Size = new Size(150, 28);
            buttonFilterGender.TabIndex = 8;
            buttonFilterGender.Text = "Фильтр по полу";
            // 
            // numericMinAge
            // 
            numericMinAge.Location = new Point(420, 200);
            numericMinAge.Name = "numericMinAge";
            numericMinAge.Size = new Size(120, 27);
            numericMinAge.TabIndex = 9;
            // 
            // numericMaxAge
            // 
            numericMaxAge.Location = new Point(500, 200);
            numericMaxAge.Name = "numericMaxAge";
            numericMaxAge.Size = new Size(120, 27);
            numericMaxAge.TabIndex = 10;
            // 
            // buttonFilterByAge
            // 
            buttonFilterByAge.Location = new Point(420, 230);
            buttonFilterByAge.Name = "buttonFilterByAge";
            buttonFilterByAge.Size = new Size(150, 28);
            buttonFilterByAge.TabIndex = 11;
            buttonFilterByAge.Text = "Фильтр по возрасту";
            // 
            // MainForm
            // 
            ClientSize = new Size(600, 650);
            Controls.Add(comboBoxGroups);
            Controls.Add(comboBoxAthletes);
            Controls.Add(buttonAddAthlete);
            Controls.Add(buttonRemoveAthlete);
            Controls.Add(dataGridViewAthletes);
            Controls.Add(buttonSortByName);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(buttonFilterGender);
            Controls.Add(numericMinAge);
            Controls.Add(numericMaxAge);
            Controls.Add(buttonFilterByAge);
            Controls.Add(comboBoxTrainers);
            Controls.Add(dataGridViewGroupsOfTrainer);
            Controls.Add(dataGridViewTrainers);
            Controls.Add(numericUpDownRating);
            Controls.Add(buttonFeedback);
            Controls.Add(comboBoxFormat);
            Controls.Add(buttonExportReport);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroupsOfTrainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMinAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMaxAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxGroups;
        private ComboBox comboBoxTrainers;
        private DataGridView dataGridViewAthletes;
        private DataGridView dataGridViewGroupsOfTrainer;
        private ComboBox comboBoxAthletes;
        private Button buttonAddAthlete;
        private Button buttonRemoveAthlete;
        private NumericUpDown numericUpDownRating;
        private Button buttonFeedback;
        private DataGridView dataGridViewTrainers;
        private ComboBox comboBoxFormat;
        private Button buttonExportReport;
        private Button buttonSortByName;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Button buttonFilterGender;
        private NumericUpDown numericMinAge;
        private NumericUpDown numericMaxAge;
        private Button buttonFilterByAge;
    }
}
