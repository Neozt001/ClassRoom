using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            StudentList = [];
        }

        //Task 4
        public override string ToString()
        {
            string str = "Class: " + ClassName + "\nStudents:\n";
            foreach(Student s in StudentList)
            {
                str += "\tName: " + s.Name +
                    ", Birth Day: " + s.BirthDay +
                    ", Birth Month: " + s.BirthMonth + "\n";
            }
            if(StudentList.Count < 1)
            {
                str += "No students";
            }
            return str + "\nSemester start: " + SemesterStart;
        }

    }
}
