using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;

namespace TeacherAccounting
{
    public partial class TeacherAccounting : Form
    {
        List<Teacher> teachersList = new List<Teacher>();
        List<Subject> subjectsList = new List<Subject>();
        List<Lesson>   lessonsList = new List<Lesson>();

        DataContractJsonSerializer teacher_jsonFormatter = new DataContractJsonSerializer(typeof(List<Teacher>));
        DataContractJsonSerializer subject_jsonFormatter = new DataContractJsonSerializer(typeof(List<Subject>));
        DataContractJsonSerializer lesson_jsonFormatter = new DataContractJsonSerializer(typeof(List<Lesson>));
        public TeacherAccounting()
        {
            InitializeComponent();
            LoadDataGrids();
            FillDataGrids();
        }

        private void Teacher_add_button_Click(object sender, EventArgs e)
        {
            teachersList.Add(new Teacher(teacher_full_name_textBox.Text, int.Parse(teacher_total_hour_allowed_textBox.Text)));
            Teachers_saveDataGrid();
            Teachers_reloadDataGrid();
        }

        private void Subject_add_button_Click(object sender, EventArgs e)
        {
            subjectsList.Add(new Subject(subject_name_textBox.Text, int.Parse(subject_total_hour_need_textBox.Text)));
            Subjects_saveDataGrid();
            Subjects_reloadDataGrid();
        }

        private void Lesson_add_button_Click(object sender, EventArgs e)
        {
            lessonsList.Add(new Lesson(lesson_subject_name_textBox.Text, lesson_teacher_name_textBox.Text));
            Lessons_saveDataGrid();
            ReloadDataGrids();
        }

        private void Teacher_delete_button_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = teachers_dataGrid.SelectedCells;
            if (selectedCells.Count > 0 && selectedCells[0].RowIndex < teachersList.Count)
            {
                teachersList.RemoveAt(selectedCells[0].RowIndex);
                Teachers_saveDataGrid();
                Teachers_reloadDataGrid();
            }
        }

        private void Subject_delete_button_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = subjects_dataGrid.SelectedCells;
            if (selectedCells.Count > 0 && selectedCells[0].RowIndex < subjectsList.Count)
            {
                subjectsList.RemoveAt(selectedCells[0].RowIndex);
                Subjects_saveDataGrid();
                Subjects_reloadDataGrid();
            }
        }

        private void Lesson_delete_button_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = lessons_dataGrid.SelectedCells;
            if (selectedCells.Count > 0 && selectedCells[0].RowIndex < lessonsList.Count)
            {
                lessonsList.RemoveAt(selectedCells[0].RowIndex);
                Lessons_saveDataGrid();
                Lessons_reloadDataGrid();
            }
        }

        void Teachers_saveDataGrid()
        {
            File.WriteAllText("teachers.json", "[]");

            using (FileStream fs = new FileStream("teachers.json", FileMode.OpenOrCreate))
            {
                teacher_jsonFormatter.WriteObject(fs, teachersList);
            }
        }

        void Subjects_saveDataGrid()
        {
            File.WriteAllText("subjects.json", "[]");

            using (FileStream fs = new FileStream("subjects.json", FileMode.OpenOrCreate))
            {
                subject_jsonFormatter.WriteObject(fs, subjectsList);
            }
        }

        void Lessons_saveDataGrid()
        {
            File.WriteAllText("lessons.json", "[]");

            using (FileStream fs = new FileStream("lessons.json", FileMode.OpenOrCreate))
            {
                lesson_jsonFormatter.WriteObject(fs, lessonsList);
            }
        }

        void SaveDataGrids()
        {
            Teachers_saveDataGrid();
            Subjects_saveDataGrid();
            Lessons_saveDataGrid();
        }

        void Teachers_loadDataGrid()
        {
            if (!File.Exists("teachers.json")) File.WriteAllText("teachers.json", "[]");

            using (FileStream fs = new FileStream("teachers.json", FileMode.OpenOrCreate))
            {
                teachersList = (List<Teacher>)teacher_jsonFormatter.ReadObject(fs);
            }
        }

        void Subjects_loadDataGrid()
        {
            if (!File.Exists("subjects.json")) File.WriteAllText("subjects.json", "[]");

            using (FileStream fs = new FileStream("subjects.json", FileMode.OpenOrCreate))
            {
                subjectsList = (List<Subject>)subject_jsonFormatter.ReadObject(fs);
            }
        }

        void Lessons_loadDataGrid()
        {
            if (!File.Exists("lessons.json")) File.WriteAllText("lessons.json", "[]");

            using (FileStream fs = new FileStream("lessons.json", FileMode.OpenOrCreate))
            {
                lessonsList = (List<Lesson>)lesson_jsonFormatter.ReadObject(fs);
            }
        }

        void LoadDataGrids()
        {
            Teachers_loadDataGrid();
            Subjects_loadDataGrid();
            Lessons_loadDataGrid();
        }

        void Teachers_reloadDataGrid()
        {
            teachers_dataGrid.Rows.Clear();
            Teachers_fillDataGrid();
        }

        void Subjects_reloadDataGrid()
        {
            subjects_dataGrid.Rows.Clear();
            Subjects_fillDataGrid();
        }

        void Lessons_reloadDataGrid()
        {
            lessons_dataGrid.Rows.Clear();
            Lessons_fillDataGrid();
        }

        void ReloadDataGrids()
        {
            Teachers_reloadDataGrid();
            Subjects_reloadDataGrid();
            Lessons_reloadDataGrid();
        }

        void Teachers_fillDataGrid()
        {
            Teachers_loadDataGrid();
            foreach( var teacher in teachersList ) teachers_dataGrid.Rows.Add(teacher.teacher_name, get_teacher_total_hours(teacher.teacher_name) + " / " + teacher.total_hour_allowed);
        }

        void Subjects_fillDataGrid()
        {
            Subjects_loadDataGrid();
            foreach (var subject in subjectsList) subjects_dataGrid.Rows.Add(subject.subject_name, get_subject_total_hours(subject.subject_name) + " / " + subject.total_hour_need);
        }

        void Lessons_fillDataGrid()
        {
            Lessons_loadDataGrid();
            foreach (var lesson in lessonsList) lessons_dataGrid.Rows.Add(lesson.lesson_name, lesson.teacher_name);
        }
         
        void FillDataGrids()
        {
            Teachers_fillDataGrid();
            Subjects_fillDataGrid();
            Lessons_fillDataGrid();
        }

        int get_teacher_total_hours(string teacher_name)
        {
            int total_hours = 0;

            foreach (var lesson in lessonsList)
            {
                if (lesson.teacher_name == teacher_name) total_hours += 2;
            }

            return total_hours;
        }

        int get_subject_total_hours(string subject_name)
        {
            int total_hours = 0;

            foreach (var lesson in lessonsList)
            {
                if (lesson.lesson_name == subject_name) total_hours += 2;
            }

            return total_hours;
        }

    }
}
