using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance
{
    class GreetEvent
    {
        public void Welcome(string FirstName)
        {
            Console.WriteLine($"Welcome {FirstName}");
        }

        public void  BanAlarm()
        {
            Console.WriteLine("Sorry! You are banned from entering!");
        }
    }
}
