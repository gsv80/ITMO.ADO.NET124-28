using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07._3
{
    internal class Program
    {
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Scores;
        }

        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {95, 84, 91, 39}},
            new Student {First="Ron", Last="Tibers", ID=113, Scores= new List<int> {58, 76, 66, 78}},
            new Student {First="Dean", Last="Toll", ID=114, Scores= new List<int> {67, 56, 87, 76}},
            new Student {First="Linn", Last="Kelt", ID=115, Scores= new List<int> {78, 67, 67, 56}},
            new Student {First="Tilly", Last="Trent", ID=116, Scores= new List<int> {60, 56, 78, 80}},
            new Student {First="Lizz", Last="Themes", ID=117, Scores= new List<int> {67, 67, 78, 80}},
        };

        static void Main(string[] args)
        {
            var studentQuery4 =
                from student in students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            foreach (var groupOfStudents in studentQuery4)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine("   {0}, {1}",student.Last, student.First);
                }
            }

            Console.WriteLine("");

            var studentQuery5 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] +
                    student.Scores[2] + student.Scores[3]
                where totalScore / 4 < student.Scores[0]
                select student.Last + " " + student.First;

            foreach (string s in studentQuery5)
            {
                Console.WriteLine(s);
            }
        }
    }
}

