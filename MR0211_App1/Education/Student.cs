using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1.Education
{
    class Student : Person
    {
        private static int mStudentId = 0;
        
        public int StudentId { get; set;  }
        public int? SignedCourseId { get; set; }
        public List<Task> CompletedTasks { get; set; }

        public Student() : base()
        {
            CompletedTasks = new List<Task>();
        }

        public Student(string name, int age) : base(name, age)
        {
            StudentId = mStudentId;
            mStudentId++;
        }

        public override string ToString()
        {
            return Name;
        }

        public void SignUpCourse(Course course)
        {

        }
    }
}
