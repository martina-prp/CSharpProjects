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

        public void AddCourse(Course newCourse)
        {
            Courses.Add(newCourse);
        }

        public void AddStudent(Student newStudent)
        {
            Students.Add(newStudent);
        }

        public void SignUpStudentToCourse(int studentId, int courseId)
        {
            var existingCourse = Courses.Find(course => course.CourseId == courseId);
            var existingStudent = Students.Find(student => student.StudentId == studentId);
            try
            {
                if (existingCourse != null && existingStudent != null)
                {
                    if (existingStudent.SignedCourseId != null)
                    {
                        throw new Exception("The student is already signed up to a course!");
                    }
                    existingCourse.AddStudentToCourse(existingStudent);
                    existingStudent.SignedCourseId =courseId;
                }
                
                if (existingCourse == null)
                {
                    throw new Exception("The Course does not exist!");
                }

                if (existingStudent == null)
                {
                    throw new Exception("The Student does not exist!");
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SignOutStudentFromCourse(int courseId, int studentId)
        {
            var existingCourse = Courses.Find(course => course.CourseId == courseId);
            var existingStudent = Students.Find(student => student.StudentId == studentId);
            try
            {
                if (existingCourse != null && existingStudent != null)
                {
                    existingCourse.RemoveStudentFromCourse(existingStudent);
                    existingStudent.SignedCourseId = null;
                }

                if (existingCourse == null)
                {
                    throw new Exception("The Course does not exist!");
                }

                if (existingStudent == null)
                {
                    throw new Exception("The Student does not exist!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public void PrintAcademy()
        {
            List<Course> sortedCourses = Courses.OrderBy(course => course.CourseName).ToList();

            foreach(Course course in sortedCourses)
            {
                Console.WriteLine(course);
                List<Student> courseStudents = Students
                    .Where(student => course.SignedStudents.Contains(student))
                    .OrderBy(student => student.Age)
                    .ToList();
                foreach(Student student in courseStudents)
                {
                    Console.WriteLine(String.Format("##{0}", student));
                }
            }
        }

    }
}
