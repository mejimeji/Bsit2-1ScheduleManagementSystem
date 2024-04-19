using Bsit2_1SubjectSchedule;
using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;


namespace BSIT2_1ClassSchedule
{
    public class Student
    {
        List<VERIFY> BSITAccount = new List<VERIFY>();

        public Student()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            //STUDENT LOGIN INFO
            VERIFY STUDN01 = new VERIFY { StudentNumber = "Tuazon_2022-00241-BN-0" };
            VERIFY STUDN02 = new VERIFY { StudentNumber = "Sayo_2022-00255-BN-0" };
            VERIFY STUDN03 = new VERIFY { StudentNumber = "Capili_2022-00473-BN-0" };
            VERIFY STUDN04 = new VERIFY { StudentNumber = "Sabdani_2022-00240-BN-0" };

            //FOR QUICK TESTING
            VERIFY STUDN05 = new VERIFY { StudentNumber = "1" };

            BSITAccount.Add(STUDN01);
            BSITAccount.Add(STUDN02);
            BSITAccount.Add(STUDN03);
            BSITAccount.Add(STUDN04);
            BSITAccount.Add(STUDN05);
        }

        public VERIFY StudentAccount(string BSITNO)
        {
            VERIFY foundStudent = new VERIFY();

            foreach (var account in BSITAccount)
            {
                if (BSITNO == account.StudentNumber)
                {
                    foundStudent = account;
                }
            }
            return foundStudent;
        }

    }
}
