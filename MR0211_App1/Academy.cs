using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1
{
    class Academy
    {
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }

        public Academy()
        {
            Courses = new List<Course>();
            Students = new List<Student>();
        }

        public bool StudentExists(string studentName)
        {
            Student found = Students.Find(student => student.Name == studentName);
            if (found is Student)
            {
                return true;
            }
            else
            {
                throw new Exception("The student does not exist in the Academy!");
            }
        }

        public bool CourseExists(string courseName)
        {
            Course found = Courses.Find(course => course.CourseName == courseName);
            if (found is Course)
            {
                return true;
            }
            else
            {
                throw new Exception("The course does not exist in the Academy!");
            }
        }

        public void AddCourse(Course newCourse)
        {
            Courses.Add(newCourse);
        }

        public void AddStudent(Student newStudent)
        {
            Students.Add(newStudent);
        }

        public void SignUpStudentToCourse(Course course, Student student)
        {
            if (StudentExists(student.Name) && CourseExists(course.CourseName))
            {
                if (student.SignedCourseId != null)
                {
                    throw new Exception("The student is already signed up to a course!");
                }
                course.AddStudentToCourse(student.StudentId);
                student.SignedCourseId = course.CourseId;
            }
        }

        public void SignOutStudentFromCourse(Course course, Student student)
        {
            if (StudentExists(student.Name) && CourseExists(course.CourseName))
            {
                course.RemoveStudentFromCourse(student.StudentId);
                student.SignedCourseId = null;
            }
        }

    }
}
