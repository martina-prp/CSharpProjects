using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1and2();
            //Task4();
            Task5();
        }

        static void Task1and2()
        {
            string name;
            int age = 1;

            Console.WriteLine("Please, enter name!");
            name = Console.ReadLine();

            try
            {
                Console.WriteLine("Please, enter age!");
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Please, enter an Integer for the age!");
                }

                Person Person1 = new Person();
                Person Person2 = new Person(name);
                Person Person3 = new Person(name, age);

                Person1.PrintPerson();
                Person2.PrintPerson();
                Person3.PrintPerson();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex);
            }
        }

        static void Task4()
        {
            List<Person> People = new List<Person>();
            People = ReadPeople();
            List<Person> NewPeople = People.OrderBy(person => person.Name.Length).Where(person => person.Age >= 18).ToList();
            PrintPeople(NewPeople);
        }

        static void Task5()
        {
            Academy Academy = new Academy();
            int courseNumber, studentNumber;

            do
            {
                Console.WriteLine("Enter the number of the courses!");
            } while (!int.TryParse(Console.ReadLine(), out courseNumber));

            for (int i = 0; i < courseNumber; i++)
            {
                Console.WriteLine("Enter course!");
                string input = Console.ReadLine();
                string[] data = input.Split(new string[] { "//" }, StringSplitOptions.None);
                string courseName = data[0];
                decimal courseDuration;
                int courseCapacity;
                bool durationInput = decimal.TryParse(data[1], out courseDuration);
                bool capacityInput = int.TryParse(data[2], out courseCapacity);
                if (!durationInput || !capacityInput)
                {
                    while (!decimal.TryParse(data[1], out courseDuration) || !int.TryParse(data[2], out courseCapacity))
                    {
                        Console.WriteLine("Enter valid values for duration or capacity!");
                    }
                }
                Course course = new Course(courseName, courseCapacity, courseDuration);
                Academy.AddCourse(course);

            }

            do
            {
                Console.WriteLine("Enter the number of the students!");
            } while (!int.TryParse(Console.ReadLine(), out studentNumber));

            for (int i = 0; i < studentNumber; i++)
            {
                Console.WriteLine("Enter student!");
                string input = Console.ReadLine();
                string[] data = input.Split(new string[] { "//" }, StringSplitOptions.None);
                string studentName = data[0];
                int studentAge;
                bool ageInput = int.TryParse(data[1], out studentAge);
                if (!ageInput)
                {
                    while (!int.TryParse(Console.ReadLine(), out studentAge))
                    {
                        Console.WriteLine("Enter valid value for age!");
                    }
                }
                Student student = new Student(studentName, studentAge);
                Academy.AddStudent(student);

            }

        }

        static List<Person> ReadPeople()
        {
            List<Person> people = new List<Person>();
            string input = null;

            while (true)
            {
                Console.WriteLine("Enter Person name and age!");
                input = Console.ReadLine();
                if ((input == "quit")) break;
                string[] data = input.Split(new string[] { "//" }, StringSplitOptions.None);
                int age;
                string name = data[0];
                bool AgeInput = int.TryParse(data[1], out age);
                if (!AgeInput) {
                    while (!int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.WriteLine("Enter valid age value!");
                    }
                }

                Person person = new Person(name, age);
                people.Add(person);
            }

            return people;
        }

        static void PrintPeople(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                people[i].PrintPerson();
            }
        }
    }
}
