using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SystemController> InstanceCollection = new Dictionary<string, SystemController>();
            var greet = new GreetEvent();

            while (true)
            {

                string NameOfInstance = Console.ReadLine();

                if (NameOfInstance == "exit")
                {
                    break;
                }
                
                var Instance = new SystemController();

                Instance.status =  (NameOfInstance == "Jack") ? Status.banned :  Status.active;

                
               

                Instance.BanAlarmEventHandler += greet.BanAlarm; 
                Instance.WelcomeEventHandler += greet.Welcome;
                Instance.Checker(NameOfInstance);

                InstanceCollection.Add(NameOfInstance, Instance);

            }


            Console.WriteLine($"Instance Collection has: {InstanceCollection.Count()}");







        }
    }
}

