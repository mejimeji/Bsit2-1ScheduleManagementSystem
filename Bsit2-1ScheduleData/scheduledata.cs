using BSIT2_1ClassSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bsit2_1SubjectSchedule
{
    public class DailySched
    {
        //METHOD FOR EACH DAY
        public void ShowMonday(Sched sched)
        {
            Console.WriteLine(sched.Monday + " PATHFIT: 3PM-5PM \r\n         QMMS: 6PM-9PM ");
        }
        public void ShowTuesday(Sched sched)
        {
            Console.WriteLine(sched.Tuesday + " INFO MANAGEMENT: 7AM-10AM \r\n          NETWORK ADMINISTRATION: 5PM-8PM "); ;
        }
        public void ShowWednesday(Sched sched)
        {
            Console.WriteLine(sched.Wednesday + " FREE ELEC 2: 2PM-5PM \r\n             HCI: 5PM-8PM ");
        }
        public void ShowThursday(Sched sched)
        {
            Console.WriteLine(sched.Thursday + " NO CLASSES ");
        }
        public void ShowFriday(Sched sched)
        {
            Console.WriteLine(sched.Friday + " NO CLASSES ");

        }
        public void ShowSaturday(Sched sched)
        {
            Console.WriteLine(sched.Saturday + " OOP: 7AM-12PM \r\n           INTEG PROG 1: 2PM-7PM ");
        }
        public void ShowSunday(Sched sched)
        {
            Console.WriteLine(sched.Sunday + " NO CLASSES ");
        }
    }
}
