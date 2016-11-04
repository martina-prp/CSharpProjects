using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR0211_App1
{
    class StudentIsBusy : Exception
    {
        public StudentIsBusy()
        {

        }

        public StudentIsBusy(string message) : base(message)
        {

        }
    }
}
