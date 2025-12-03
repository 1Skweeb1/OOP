using ClassLibrary;
using System.Xml.Linq;
using System.Collections.Generic;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private SessionLib Session;
        public Form1()
        {
            InitializeComponent();

            Session = new SessionLib(students);
            string StName = StudentName.Text;
            string StGroup = StudentGroup.Text;

            StudentGroup.Items.Add("ITI-21");
            StudentGroup.Items.Add("ITP-21");
            StudentGroup.Items.Add("ITD-21");

            StudentGroup2.Items.Add("ITI-21");
            StudentGroup2.Items.Add("ITP-21");
            StudentGroup2.Items.Add("ITD-21");

            Subjects.Items.Add("OOP");
            Subjects.Items.Add("OS");
            Subjects.Items.Add("SYAP");
            Subjects.Items.Add("VYAP");
            Subjects.Items.Add("DISCRETKA");

        }


        private void AddStudent_Click(object sender, EventArgs e)
        {

            Student student = new Student(StudentName.Text, StudentGroup.Text);
            student.Grades.Add("OOP", (int)OOPGrade.Value);
            student.Grades.Add("OS", (int)OSGrade.Value);
            student.Grades.Add("SYAP", (int)SYAPGrade.Value);
            student.Grades.Add("VYAP", (int)VYAPGrade.Value);
            student.Grades.Add("DISCRETKA", (int)DISCRETKAGrade.Value);
            students.Add(student);

            string gradesStr = string.Join(", ", student.Grades.Select(g => $"{g.Key}: {g.Value}"));
            StudentsLabel.Text += $"{student.Name} ({student.Group}) — {gradesStr}\n";
        }

        private void AverageBySubject_Click(object sender, EventArgs e)
        {
            double OOPGrade = Session.GetAverageGradeBySubject("OOP");
            double OSGrade = Session.GetAverageGradeBySubject("OS");
            double SYAPGrade = Session.GetAverageGradeBySubject("SYAP");
            double VYAPGrade = Session.GetAverageGradeBySubject("VYAP");
            double DISCRETKAGrade = Session.GetAverageGradeBySubject("DISCRETKA");
            Answer1.Text = $"OOP: {OOPGrade:F2},\n OS: {OSGrade:F2},\n SYAP: {SYAPGrade:F2},\n VYAP: {VYAPGrade:F2},\n DISCRETKA: {DISCRETKAGrade:F2}";
        }

        private void AverageByGroup_Click(object sender, EventArgs e)
        {
            string Group = StudentGroup2.Text;
            double AverageByGroup = Session.GetAverageGradeByGroup(Group);
            Answer2.Text = $"{AverageByGroup}";
        }

        private void GetBadStudents_Click(object sender, EventArgs e)
        {
            string Subject = Subjects.Text;
            int BadStudents = Session.GetCountBadStudents(Subject);
            Answer3.Text = $"{BadStudents}";
        }

    }
}
