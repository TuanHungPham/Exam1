using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTest
{
    internal class TestStudent
    {
        public List<Student> studentList = new List<Student>();

        public void Input(Student student)
        {
            Console.WriteLine("------------- INPUT STUDENT'S INFORMATION -------------");
            Console.Write("ID: ");
            student.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Gender: ");
            student.Gender = Console.ReadLine();
            Console.Write("Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Date of Birth: ");
            student.Dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Class: ");
            student.Class = Console.ReadLine();            
            Console.Write("Mark 1: ");
            student.Mark1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mark 2: ");
            student.Mark2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mark 3: ");
            student.Mark3 = Convert.ToDouble(Console.ReadLine());
        }

        public void EditInformation(int i)
        {
            Console.WriteLine("------------- EDIT STUDENT'S INFORMATION -------------");
            Console.Write("ID: ");
            studentList[i].Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            studentList[i].Name = Console.ReadLine();
            Console.Write("Age: ");
            studentList[i].Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Date of Birth: ");
            studentList[i].Dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Class: ");
            studentList[i].Class = Console.ReadLine();
            Console.Write("Mark 1: ");
            studentList[i].Mark1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mark 2: ");
            studentList[i].Mark2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mark 3: ");
            studentList[i].Mark3 = Convert.ToDouble(Console.ReadLine());
        }

        public void FindStudentByName(string name)
        {
            Student student = studentList.Find((x) => x.Name == name);

            if (student == null)
            {
                Console.WriteLine("Can't find student!");
                return;
            }

            Console.WriteLine("Find success!");
            Display(student);
        }

        public void DeleteStudentByID(int id)
        {
            Student student = studentList.Find((x) => x.Id == id);

            if (student == null)
            {
                Console.WriteLine("Can't find student!");
                return;
            }

            studentList.Remove(student);
            Console.WriteLine("Delete success!");
        }

        public void Sort()
        {
            studentList.Sort
                (
                    (a, b) => a.mark_AVG().CompareTo(b.mark_AVG())
                );
        }

        public void Display(Student student)
        {
            Console.WriteLine("------------- DISPLAY STUDENT'S INFORMATION -------------");
            Console.WriteLine("ID: " + student.Id);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Date of Birth: {0:dd/MM/yyyy}", student.Dob);
            Console.WriteLine("Class: " + student.Class);
            Console.WriteLine("Mark 1: " + student.Mark1);
            Console.WriteLine("Mark 2: " + student.Mark2);
            Console.WriteLine("Mark 3: " + student.Mark3);
            Console.WriteLine("Average: " + student.mark_AVG());
            Console.WriteLine();
        }
    }
}
