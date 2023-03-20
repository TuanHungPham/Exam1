using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTest
{
    internal class Student
    {
        private int id, age;
        private DateTime dob;
        private string? name, gender, _class;
        private double mark1, mark2, mark3;

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string? Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inputted Name is not valid!!");
                }
                name = value;
            }
        }
        public string? Gender
        {
            get => gender;
            set
            {
                if (value != "Male" && value != "Female" && value != "male" && value != "female")
                {
                    throw new ArgumentException("Only Male or Female allowed here!");
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inputted Gender is not valid!!");
                }
                gender = value;
            }
        }

        public string? Class
        {
            get => _class;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inputted Class is not valid!!");
                }
                _class = value;
            }
        }

        public double Mark1
        {
            get => mark1;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Mark has to be a number and only between 0 and 100!!!");
                }
                mark1 = value;
            }
        }

        public double Mark2
        {
            get => mark2;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Mark has to be a number and only between 0 and 100!!!");
                }
                mark2 = value;
            }
        }

        public double Mark3
        {
            get => mark3;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Mark has to be a number and only between 0 and 100!!!");
                }
                mark3 = value;
            }
        }

        public DateTime Dob { get => dob; set => dob = value; }

        public double mark_AVG()
        {
            return (mark1 + mark2 + mark3) / 3;
        }
    }
}
