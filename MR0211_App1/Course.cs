using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1
{
    class Course
    {
        private static int mCourseId = 0;

        public int Capacity { get; set; }
        public string CourseName { get; set; }
        public decimal Duration { get; set; }
        public List<Student> SignedStudents { get; set; }
        public int CourseId { get; set; }

        public Course(string name, int capacity, decimal duration)
        {
            CourseName = name;
            Capacity = capacity;
            Duration = duration;
            SignedStudents = new List<Student>();
            CourseId = mCourseId;
            mCourseId++;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} hours", CourseName, Duration);
        }

        public List<Student> IsStudentExistingByName(string checkName)
        {
            List<Student> studentsFound = SignedStudents.FindAll(ss => ss.Name == checkName);
            if (studentsFound.Count == 0)
            {
                throw new Exception(String.Format("Student {0} has not been found!", checkName));
            }
            return studentsFound;
        }

        public bool IsAlreadySigned(int studentId)
        {
            var isFound = SignedStudents.Find(st => st.StudentId == studentId);
            if (isFound != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddStudentToCourse(Student student)
        {
            if (!IsAlreadySigned(student.StudentId)) {
                if (SignedStudents.Count + 1 > Capacity)
                {
                    throw new Exception(String.Format("Course {0} is full and the student can not be added to it!", CourseName));
                }
                SignedStudents.Add(student);
            }
            else
            {
                throw new Exception("The student is already signed up for this course!");
            }
        }

        public void RemoveStudentFromCourse(Student student)
        {
            if (IsAlreadySigned(student.StudentId)) {
                SignedStudents.Remove(student);
            }
            else
            {
                throw new Exception("The student can not be removed because he is not signed up to this course!");
            }
        }
    }
}
