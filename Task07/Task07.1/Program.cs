using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07._1
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
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90
                select student;
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }
        }
    }
}
