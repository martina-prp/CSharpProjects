using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1
{
    class CourseNotFound : Exception
    {
        public CourseNotFound()
        {
 
        }

        public CourseNotFound(string message) : base(message)
        {

        }

    }
}
