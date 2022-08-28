using System;

namespace Homework
{
   class School
    {
        public static void Main()
        {
            Classroom a = new Classroom();
            Console.WriteLine("Pupils:");
            a.Students();
            Console.WriteLine("New classroom mate:");
            a.NewStudent = "Adam Rigs\n";
            Console.WriteLine(a.NewStudent);

            Student student = new Student();
            Console.WriteLine(student.StudentGreeting("Hi," + " "));
            Console.WriteLine("\n");

            Shedule b = new Shedule();
            Console.WriteLine("Standart Shedule:");
            b.StandartShedule();
            Console.WriteLine("\n");

            Teacher c = new Teacher();
            Console.WriteLine("Teacher info:");
            c.TeachersInfo();
            Console.WriteLine("\n");
            Console.WriteLine("Updated teacher info:");
            Console.WriteLine(c.LessonName + " - " + "teacher replacement, more details you`ll get on the lesson");
            c.NewTeacher = "Helen Maddison";
        }
    }

    class Classroom
    {
        private string NewStudents;//the private local variable should have name start from normal cheracter (not capital), e.g. newStudents
        public string NewStudent//since the NewStudent property is public handle for the private field NewStudents - its name should correspond to the private field name, e.g it should be NewStudents
        {
            get { return NewStudents; }
            set { NewStudents = value; }
        }
        public void Students()//the void name should be more meaningful. This void do printout the pupils - ok, let is be something like PrinStudents or GetStudents
        {
            string[] Pupils = new string[]
            {
                "Bob Morley",
                "Matteo Wilson",
                "Jughead Jones"
            };
            
            foreach (var k in Pupils)
            {
                Console.WriteLine(k);
            }
        }
    }

    class Student
    {
        public string StudentGreeting(string message)
        {
            Console.WriteLine("Hi, please, enter your name");
            string Name = Console.ReadLine();
            return message + Name;
        }
    }

    class Shedule
    {
        public void StandartShedule()
        {
            string[] SheduleArray = new string[]
            {
            "Monday - 10:30 - Math",
            "Tuesday - 9:00 - History",
            "Wednesday - 10:30 - Biology",
            "Thursday - 10:30 - Physics",
            "Friday - 9:00 - Math"
            };

            foreach (var i in SheduleArray)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Teacher
    {
        public void TeachersInfo()
        {
            string[] Teachers = new string[]
            {
            "Math - Anthony Hobbs",
            "History - Hanna Baker",
            "Biology - Kate Williams",
            "Physics - Carl Johnson"
            };

            foreach (var j in Teachers)
            {
                Console.WriteLine(j);
            }
        }

        string Lesson = "Math";
        string TeacherName = "Anthony Hobbs";//private local field name should start from lowercase character, e.g. teacherName

        public string NewTeacher//the property name should correspond to the local field name, in your case it should be TeacherName
        {
            set { TeacherName = value; }
        }
        public string LessonName
        {
            get { return Lesson; }
        }
    }
}
//checked
