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
        public List<int> SignedStudentsIds { get; set; }
        public int CourseId { get; set; }

        public Course(string name, int capacity, decimal duration)
        {
            CourseName = name;
            Capacity = capacity;
            Duration = duration;
            SignedStudentsIds = null;
            CourseId = mCourseId;
            mCourseId++;
        }

        public override string ToString()
        {
            return CourseName;
        }

        public bool IsAlreadySigned(int studentId)
        {
            bool isFound = SignedStudentsIds.Contains(studentId);
            return isFound;
        }

        public void AddStudentToCourse(int studentId)
        {
            if (!IsAlreadySigned(studentId)) {
                if (SignedStudentsIds.Count + 1 >= Capacity)
                {
                    throw new Exception("The course is full and the student can not be added to it!");
                }
                SignedStudentsIds.Add(studentId);
            }
            else
            {
                throw new Exception("The student is already signed up for this course!");
            }
        }

        public void RemoveStudentFromCourse(int studentId)
        {
            if (IsAlreadySigned(studentId)) {
                SignedStudentsIds.Remove(studentId);
            }
            else
            {
                throw new Exception("The student can not be removed because he is not signed up to this course!");
            }
        }
    }
}
