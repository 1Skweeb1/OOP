using System.Diagnostics.Metrics;

namespace ClassLibrary
{
    public class SessionLib
    {
        private List<Student> Students;

        public SessionLib(List<Student> Students) {
            this.Students = Students;
        }

        public double GetAverageGradeBySubject(String SubjectName)
        {
            double Counter = 0;
            double SumGrades = 0;
            foreach (Student student in Students)
            {
                if (student.Grades.ContainsKey(SubjectName))
                {
                    SumGrades += student.Grades[SubjectName]; 
                    Counter++;
                }
            }

            return SumGrades / Counter;
        }

        public double GetAverageGradeByGroup(String GroupName)
        {
            double Counter = 0;
            double SumGrades = 0;
            foreach (Student student in Students)
            {
                if (student.Group.Equals(GroupName))
                {
                    foreach(int Grade in student.Grades.Values)
                    {
                        SumGrades += Grade;
                        Counter++;
                    }
                }
            }
            if (Counter == 0) { 
                return 0;
            }
            return SumGrades / Counter;        
        }

        public int GetCountBadStudents(String SubjectName)
        {
            int Counter = 0;
            foreach (Student student in Students)
            {
                if (student.Grades.ContainsKey(SubjectName))
                {
                    if (student.Grades[SubjectName] < 4)
                    {
                        Counter++;
                    }
                }
            }

            return Counter;
        }
    }
}
