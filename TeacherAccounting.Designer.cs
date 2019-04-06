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
            this.subject_label = new System.Windows.Forms.Label();
            this.full_name_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.subject_textBox = new System.Windows.Forms.TextBox();
            this.full_name_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjects = new System.Windows.Forms.TabPage();
            this.lessons = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.teachers.Controls.Add(this.subject_label);
            this.teachers.Controls.Add(this.full_name_label);
            this.teachers.Controls.Add(this.delete_button);
            this.teachers.Controls.Add(this.add_button);
            this.teachers.Controls.Add(this.subject_textBox);
            this.teachers.Controls.Add(this.full_name_textBox);
            this.teachers.Controls.Add(this.dataGridView1);
            this.teachers.Name = "teachers";
            this.teachers.UseVisualStyleBackColor = true;
            // 
            // subject_label
            // 
            resources.ApplyResources(this.subject_label, "subject_label");
            this.subject_label.Name = "subject_label";
            // 
            // full_name_label
            // 
            resources.ApplyResources(this.full_name_label, "full_name_label");
            this.full_name_label.Name = "full_name_label";
            // 
            // delete_button
            // 
            resources.ApplyResources(this.delete_button, "delete_button");
            this.delete_button.Name = "delete_button";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            resources.ApplyResources(this.add_button, "add_button");
            this.add_button.Name = "add_button";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // subject_textBox
            // 
            resources.ApplyResources(this.subject_textBox, "subject_textBox");
            this.subject_textBox.Name = "subject_textBox";
            // 
            // full_name_textBox
            // 
            resources.ApplyResources(this.full_name_textBox, "full_name_textBox");
            this.full_name_textBox.Name = "full_name_textBox";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.full_name,
            this.subject,
            this.hours});
            this.dataGridView1.Name = "dataGridView1";
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
            this.subjects.Name = "subjects";
            this.subjects.UseVisualStyleBackColor = true;
            // 
            // lessons
            // 
            resources.ApplyResources(this.lessons, "lessons");
            this.lessons.Name = "lessons";
            this.lessons.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage teachers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.TabPage subjects;
        private System.Windows.Forms.TabPage lessons;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox subject_textBox;
        private System.Windows.Forms.TextBox full_name_textBox;
    }
}

