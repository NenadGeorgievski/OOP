using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudentPersonAndTeacher
{
    public class StudentTeacherTest
    {
        public void Main() 
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            student.Study();
            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.Explain();
        }
    }
}
