using BSIT2_1ClassSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsit2_1SubjectSchedule
{
    public class SudentVerify
    {
        public bool VerifyBsitAccount(string surname)
        {
            Student StudentService = new Student();
            var result = StudentService.StudentAccount(surname);
            return result.StudentNumber != null ? true : false;
        }
    }
}
