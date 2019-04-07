namespace TeacherAccounting
{
    partial class TeacherAccounting
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAccounting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.teachers = new System.Windows.Forms.TabPage();
            this.teacher_subject_label = new System.Windows.Forms.Label();
            this.teacher_full_name_label = new System.Windows.Forms.Label();
            this.teacher_delete_button = new System.Windows.Forms.Button();
            this.teacher_add_button = new System.Windows.Forms.Button();
            this.teacher_subject_textBox = new System.Windows.Forms.TextBox();
            this.teacher_full_name_textBox = new System.Windows.Forms.TextBox();
            this.teachers_dataGrid = new System.Windows.Forms.DataGridView();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjects = new System.Windows.Forms.TabPage();
            this.lessons = new System.Windows.Forms.TabPage();
            this.subject_total_hour_need_label = new System.Windows.Forms.Label();
            this.subject_name_label = new System.Windows.Forms.Label();
            this.subject_delete_button = new System.Windows.Forms.Button();
            this.subject_add_button = new System.Windows.Forms.Button();
            this.subject_total_hour_need_textBox = new System.Windows.Forms.TextBox();
            this.subject_name_textBox = new System.Windows.Forms.TextBox();
            this.subjects_dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesson_teacher_name_label = new System.Windows.Forms.Label();
            this.lesson_subject_name_label = new System.Windows.Forms.Label();
            this.lesson_delete_button = new System.Windows.Forms.Button();
            this.lesson_add_button = new System.Windows.Forms.Button();
            this.lesson_teacher_name_textBox = new System.Windows.Forms.TextBox();
            this.lesson_subject_name_textBox = new System.Windows.Forms.TextBox();
            this.lessons_dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_dataGrid)).BeginInit();
            this.subjects.SuspendLayout();
            this.lessons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessons_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.teachers);
            this.tabControl1.Controls.Add(this.subjects);
            this.tabControl1.Controls.Add(this.lessons);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // teachers
            // 
            resources.ApplyResources(this.teachers, "teachers");
            this.teachers.Controls.Add(this.teacher_subject_label);
            this.teachers.Controls.Add(this.teacher_full_name_label);
            this.teachers.Controls.Add(this.teacher_delete_button);
            this.teachers.Controls.Add(this.teacher_add_button);
            this.teachers.Controls.Add(this.teacher_subject_textBox);
            this.teachers.Controls.Add(this.teacher_full_name_textBox);
            this.teachers.Controls.Add(this.teachers_dataGrid);
            this.teachers.Name = "teachers";
            this.teachers.UseVisualStyleBackColor = true;
            // 
            // teacher_subject_label
            // 
            resources.ApplyResources(this.teacher_subject_label, "teacher_subject_label");
            this.teacher_subject_label.Name = "teacher_subject_label";
            // 
            // teacher_full_name_label
            // 
            resources.ApplyResources(this.teacher_full_name_label, "teacher_full_name_label");
            this.teacher_full_name_label.Name = "teacher_full_name_label";
            // 
            // teacher_delete_button
            // 
            resources.ApplyResources(this.teacher_delete_button, "teacher_delete_button");
            this.teacher_delete_button.Name = "teacher_delete_button";
            this.teacher_delete_button.UseVisualStyleBackColor = true;
            // 
            // teacher_add_button
            // 
            resources.ApplyResources(this.teacher_add_button, "teacher_add_button");
            this.teacher_add_button.Name = "teacher_add_button";
            this.teacher_add_button.UseVisualStyleBackColor = true;
            this.teacher_add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // teacher_subject_textBox
            // 
            resources.ApplyResources(this.teacher_subject_textBox, "teacher_subject_textBox");
            this.teacher_subject_textBox.Name = "teacher_subject_textBox";
            // 
            // teacher_full_name_textBox
            // 
            resources.ApplyResources(this.teacher_full_name_textBox, "teacher_full_name_textBox");
            this.teacher_full_name_textBox.Name = "teacher_full_name_textBox";
            // 
            // teachers_dataGrid
            // 
            resources.ApplyResources(this.teachers_dataGrid, "teachers_dataGrid");
            this.teachers_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachers_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.full_name,
            this.subject,
            this.hours});
            this.teachers_dataGrid.Name = "teachers_dataGrid";
            // 
            // full_name
            // 
            resources.ApplyResources(this.full_name, "full_name");
            this.full_name.Name = "full_name";
            // 
            // subject
            // 
            resources.ApplyResources(this.subject, "subject");
            this.subject.Name = "subject";
            // 
            // hours
            // 
            resources.ApplyResources(this.hours, "hours");
            this.hours.Name = "hours";
            // 
            // subjects
            // 
            resources.ApplyResources(this.subjects, "subjects");
            this.subjects.Controls.Add(this.subject_total_hour_need_label);
            this.subjects.Controls.Add(this.subject_name_label);
            this.subjects.Controls.Add(this.subject_delete_button);
            this.subjects.Controls.Add(this.subject_add_button);
            this.subjects.Controls.Add(this.subject_total_hour_need_textBox);
            this.subjects.Controls.Add(this.subject_name_textBox);
            this.subjects.Controls.Add(this.subjects_dataGrid);
            this.subjects.Name = "subjects";
            this.subjects.UseVisualStyleBackColor = true;
            // 
            // lessons
            // 
            resources.ApplyResources(this.lessons, "lessons");
            this.lessons.Controls.Add(this.lesson_teacher_name_label);
            this.lessons.Controls.Add(this.lesson_subject_name_label);
            this.lessons.Controls.Add(this.lesson_delete_button);
            this.lessons.Controls.Add(this.lesson_add_button);
            this.lessons.Controls.Add(this.lesson_teacher_name_textBox);
            this.lessons.Controls.Add(this.lesson_subject_name_textBox);
            this.lessons.Controls.Add(this.lessons_dataGrid);
            this.lessons.Name = "lessons";
            this.lessons.UseVisualStyleBackColor = true;
            // 
            // subject_total_hour_need_label
            // 
            resources.ApplyResources(this.subject_total_hour_need_label, "subject_total_hour_need_label");
            this.subject_total_hour_need_label.Name = "subject_total_hour_need_label";
            // 
            // subject_name_label
            // 
            resources.ApplyResources(this.subject_name_label, "subject_name_label");
            this.subject_name_label.Name = "subject_name_label";
            // 
            // subject_delete_button
            // 
            resources.ApplyResources(this.subject_delete_button, "subject_delete_button");
            this.subject_delete_button.Name = "subject_delete_button";
            this.subject_delete_button.UseVisualStyleBackColor = true;
            // 
            // subject_add_button
            // 
            resources.ApplyResources(this.subject_add_button, "subject_add_button");
            this.subject_add_button.Name = "subject_add_button";
            this.subject_add_button.UseVisualStyleBackColor = true;
            // 
            // subject_total_hour_need_textBox
            // 
            resources.ApplyResources(this.subject_total_hour_need_textBox, "subject_total_hour_need_textBox");
            this.subject_total_hour_need_textBox.Name = "subject_total_hour_need_textBox";
            // 
            // subject_name_textBox
            // 
            resources.ApplyResources(this.subject_name_textBox, "subject_name_textBox");
            this.subject_name_textBox.Name = "subject_name_textBox";
            // 
            // subjects_dataGrid
            // 
            resources.ApplyResources(this.subjects_dataGrid, "subjects_dataGrid");
            this.subjects_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjects_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.subjects_dataGrid.Name = "subjects_dataGrid";
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lesson_teacher_name_label
            // 
            resources.ApplyResources(this.lesson_teacher_name_label, "lesson_teacher_name_label");
            this.lesson_teacher_name_label.Name = "lesson_teacher_name_label";
            // 
            // lesson_subject_name_label
            // 
            resources.ApplyResources(this.lesson_subject_name_label, "lesson_subject_name_label");
            this.lesson_subject_name_label.Name = "lesson_subject_name_label";
            // 
            // lesson_delete_button
            // 
            resources.ApplyResources(this.lesson_delete_button, "lesson_delete_button");
            this.lesson_delete_button.Name = "lesson_delete_button";
            this.lesson_delete_button.UseVisualStyleBackColor = true;
            // 
            // lesson_add_button
            // 
            resources.ApplyResources(this.lesson_add_button, "lesson_add_button");
            this.lesson_add_button.Name = "lesson_add_button";
            this.lesson_add_button.UseVisualStyleBackColor = true;
            // 
            // lesson_teacher_name_textBox
            // 
            resources.ApplyResources(this.lesson_teacher_name_textBox, "lesson_teacher_name_textBox");
            this.lesson_teacher_name_textBox.Name = "lesson_teacher_name_textBox";
            // 
            // lesson_subject_name_textBox
            // 
            resources.ApplyResources(this.lesson_subject_name_textBox, "lesson_subject_name_textBox");
            this.lesson_subject_name_textBox.Name = "lesson_subject_name_textBox";
            // 
            // lessons_dataGrid
            // 
            resources.ApplyResources(this.lessons_dataGrid, "lessons_dataGrid");
            this.lessons_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessons_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.lessons_dataGrid.Name = "lessons_dataGrid";
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // TeacherAccounting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "TeacherAccounting";
            this.tabControl1.ResumeLayout(false);
            this.teachers.ResumeLayout(false);
            this.teachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_dataGrid)).EndInit();
            this.subjects.ResumeLayout(false);
            this.subjects.PerformLayout();
            this.lessons.ResumeLayout(false);
            this.lessons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessons_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage teachers;
        private System.Windows.Forms.DataGridView teachers_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.TabPage subjects;
        private System.Windows.Forms.TabPage lessons;
        private System.Windows.Forms.Label teacher_subject_label;
        private System.Windows.Forms.Label teacher_full_name_label;
        private System.Windows.Forms.Button teacher_delete_button;
        private System.Windows.Forms.Button teacher_add_button;
        private System.Windows.Forms.TextBox teacher_subject_textBox;
        private System.Windows.Forms.TextBox teacher_full_name_textBox;
        private System.Windows.Forms.Label subject_total_hour_need_label;
        private System.Windows.Forms.Label subject_name_label;
        private System.Windows.Forms.Button subject_delete_button;
        private System.Windows.Forms.Button subject_add_button;
        private System.Windows.Forms.TextBox subject_total_hour_need_textBox;
        private System.Windows.Forms.TextBox subject_name_textBox;
        private System.Windows.Forms.DataGridView subjects_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lesson_teacher_name_label;
        private System.Windows.Forms.Label lesson_subject_name_label;
        private System.Windows.Forms.Button lesson_delete_button;
        private System.Windows.Forms.Button lesson_add_button;
        private System.Windows.Forms.TextBox lesson_teacher_name_textBox;
        private System.Windows.Forms.TextBox lesson_subject_name_textBox;
        private System.Windows.Forms.DataGridView lessons_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

