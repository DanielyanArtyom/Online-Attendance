using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance
{
    class SystemController
    {

        public Status status { get; set; }

        public event Action BanAlarmEventHandler;
        public event Action<string> WelcomeEventHandler;


        public void Checker(string name)
        {
            if (status == Status.banned)
            {
                BanAlarmEventHandler?.Invoke();
            }
            if(status == Status.active)
            {
                WelcomeEventHandler?.Invoke(name);
            }
        }



    }
}
