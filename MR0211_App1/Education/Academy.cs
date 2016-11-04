using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1.Education
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
                if (existingStudent != null)
                {
                    if (existingStudent.SignedCourseId != null)
                    {
                        throw new StudentIsBusy("The student is already signed up to a course!");
                    }
                    if (existingCourse != null)
                    {
                        existingCourse.AddStudentToCourse(existingStudent);
                        existingStudent.SignedCourseId = courseId;
                    }
                    else
                    {
                        throw new CourseNotFound("The Course does not exist!");
                    }
                }
                else
                {
                    throw new StudentNotFound("The Student does not exist!");
                }

            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch(StudentIsBusy sb)
            {
                Console.WriteLine(sb.Message);
            }

        }

        public void SignOutStudentFromCourse(int courseId, int studentId)
        {
            var existingCourse = Courses.Find(course => course.CourseId == courseId);
            var existingStudent = Students.Find(student => student.StudentId == studentId);
            try
            {
                if (existingCourse != null)
                {
                    if (existingStudent != null)
                    {
                        existingCourse.RemoveStudentFromCourse(existingStudent);
                        existingStudent.SignedCourseId = null;
                    }
                    else
                    {
                        throw new StudentNotFound("The Student does not exist!");
                    }
                }
                else
                {
                    throw new CourseNotFound("The Course does not exist!");
                }
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
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
