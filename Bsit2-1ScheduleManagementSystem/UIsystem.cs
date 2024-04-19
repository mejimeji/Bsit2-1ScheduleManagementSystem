using BSIT2_1ClassSchedule;
using Bsit2_1SubjectSchedule;

namespace ClassSchedule
{
    public class Class3
    {
        class Program

        {
            static void Main(string[] args)

            {
                Console.WriteLine("  <><><><><><><><><><><><><><><><><>");
                Console.WriteLine("    ENTER Surname_Student Number ");
                Console.WriteLine("  <><><><><><><><><><><><><><><><><>");
                Console.WriteLine();

                string surname = Console.ReadLine();

                SudentVerify accountServices = new SudentVerify();
                bool result = accountServices.VerifyBsitAccount(surname);


                if (result)
                {
                    Console.WriteLine();
                    Console.WriteLine("  <><><><><><><><><><><><><><><><>");
                    Console.WriteLine("    You are enrolled in BSIT 2-1  ");
                    Console.WriteLine("  <><><><><><><><><><><><><><><><>");
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine();
                    Console.WriteLine("  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.WriteLine("    You are not enrolled in BSIT 2-1 ");
                    Console.WriteLine("  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.WriteLine();
                    return;
                }


                Console.WriteLine("  ---------------------------------");
                Console.WriteLine("    BSIT 2-1 Daily Class Schedule   ");
                Console.WriteLine("  --------------------------------- ");

                Console.WriteLine();
                Console.WriteLine("\r\n    Choose from Monday to Sunday  ");
                Console.WriteLine();

                DailySched Bsit2_1SubjectSchedule = new DailySched();


                string day = Console.ReadLine();

                {
                    switch (day)
                    {
                        case "Monday":
                            Sched monday = new Sched();
                            monday.Monday = " Monday:";
                            Console.WriteLine();
                            Console.WriteLine("  ------------------------------ ");
                            Console.WriteLine("    Your Monday Class Schedule");
                            Console.WriteLine("  ------------------------------ ");
                            Console.WriteLine();
                            Bsit2_1SubjectSchedule.ShowMonday(monday);
                            break;

                        case "Tuesday":
                            Sched tuesday = new Sched();
                            tuesday.Tuesday = " Tuesday:";
                            Console.WriteLine();
                            Console.WriteLine("  ----------------------------- ");
                            Console.WriteLine("   Your Tuesday Class Schedule");
                            Console.WriteLine("  ----------------------------- ");
                            Console.WriteLine();
                            Bsit2_1SubjectSchedule.ShowTuesday(tuesday);
                            break;

                        case "Wednesday":
                            Sched wednesday = new Sched();
                            wednesday.Wednesday = "  Wednesday:";
                            Console.WriteLine();
                            Console.WriteLine("  ------------------------------- ");
                            Console.WriteLine("   Your Wednesday Class Schedule");
                            Console.WriteLine("  ------------------------------- ");
                            Console.WriteLine();
                            Bsit2_1SubjectSchedule.ShowWednesday(wednesday);
                            break;

                        case "Thursday":
                            Sched thursday = new Sched();
                            thursday.Thursday = "  Thursday:";
                            Console.WriteLine();
                            Console.WriteLine("  ------------------------------ ");
                            Console.WriteLine("   Your Thursday Class Schedule");
                            Console.WriteLine("  ------------------------------ ");
                            Console.WriteLine();
                            Bsit2_1SubjectSchedule.ShowThursday(thursday);
                            break;

                        case "Friday":
                            Sched friday = new Sched();
                            friday.Friday = " Friday:";
                            Console.WriteLine();
                            Console.WriteLine("  ---------------------------- ");
                            Console.WriteLine("   Your Friday Class Schedule");
                            Console.WriteLine("  ---------------------------- ");
                            Console.WriteLine();
                            Bsit2_1SubjectSchedule.ShowFriday(friday);
                            break;

                        case "Saturday":
                            Sched saturday = new Sched();
                            saturday.Saturday = " Saturday:";
                            Console.WriteLine();
                            Console.WriteLine("  ------------------------------ ");
                            Console.WriteLine("   Your Saturday Class Schedule");
                            Console.WriteLine("  ------------------------------ ");
                            Console.WriteLine();
                            Bsit2_1SubjectSchedule.ShowSaturday(saturday);
                            break;

                        case "Sunday":
                            Sched sunday = new Sched();
                            sunday.Sunday = " Sunday:";
                            Console.WriteLine();
                            Console.WriteLine("  ---------------------------- ");
                            Console.WriteLine("   Your Sunday Class Schedule");
                            Console.WriteLine("  ---------------------------- ");
                            Console.WriteLine();
                            Bsit2_1SubjectSchedule.ShowSunday(sunday);
                            break;

                    }

                }

            }

        }

    }
}
