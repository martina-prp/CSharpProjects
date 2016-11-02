using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1
{
    class Person
    {
        string name;
        int age;

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("The age can not be negative!!!");
                }
                age = value;
            }
        }

        public Person()
        {
            this.name = "No Name";
            this.age = 1;
        }

        public Person(string pname) : this()
        {
            Name = pname;
        }

        public Person(string pname, int page) : this(pname)
        {
            Age = page;
        }

        public void PrintPerson()
        {
            Console.WriteLine("{0} {1}", Name, Age);
        }
    }
}
