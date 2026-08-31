// Task 3
using ClassRoomNet60;

ClassRoom c1 = new ClassRoom();
c1.ClassName = "3Q";
c1.SemesterStart = new DateTime(2019, 8, 26);

Student s1 = new Student("S1", 1, 1);
Student s2 = new Student("S2", 2, 2);
Student s3 = new Student("S3", 3, 3);

c1.StudentList.Add(s1);
c1.StudentList.Add(s2);
c1.StudentList.Add(s3);

// Task 4
Console.WriteLine(c1);
// Task 5
Console.WriteLine(s3.Season());

//Task 6
c1.CountBirthDaySeasons();