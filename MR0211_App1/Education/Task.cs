using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1.Education
{
    class Task
    {
        public string TaskName { get; set; }
        public float TaskGrade { get; set; }
        public DateTime TaskCreatedDate { get; set; }

        public Task(string name, float grade, DateTime date)
        {
            TaskName = name;
            TaskGrade = grade;
            TaskCreatedDate = date;
        }
    }

}
