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

        //Task 6 
        public void CountBirthDaySeasons()
        {
            int winterTotal = 0;
            int springTotal = 0;
            int summerTotal = 0;
            int autumnTotal = 0;

            foreach(Student s in StudentList)
            {
                if(s.BirthMonth == 12 || s.BirthMonth == 1 || s.BirthMonth == 2)
                {
                    winterTotal++;
                }
                if(s.BirthMonth == 3 || s.BirthMonth == 4 || s.BirthMonth == 5)
                {
                    springTotal++;
                }
                if(s.BirthMonth == 6 || s.BirthMonth == 7 || s.BirthMonth == 8)
                {
                    summerTotal++;
                }
                if(s.BirthMonth == 9 || s.BirthMonth == 10 || s.BirthMonth == 11)
                {
                    autumnTotal++;
                }
            }
            Console.WriteLine("BirthDays in each season: " +
                "\n\tWinter: " + winterTotal +
                "\n\tSpring: " + springTotal +
                "\n\tSummer: " + summerTotal +
                "\n\tAutumn: " + autumnTotal);
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
