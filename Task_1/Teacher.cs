using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Teacher:Person
    {
        private List<Student> _students;

        public List<Student> Students {
            get { return _students; }
            set { _students = value; }
        }

        public Teacher() : base()
        {
            for (int i = 0; i < this.Students.Count; i++)
            {
                Students[i] = new Student();
            }
        }
        
        public Teacher(string fullName, int age, List<Student> students) : base(fullName, age)
        {
            Students = students;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter teacher's students: ");
            foreach (Student student in _students) {
                student.Input();
            }
        }

        public override void Print()
        {
            Console.WriteLine("Teacher:");
            base.Print();
            Console.WriteLine("Teacher's students: ");
            foreach (Student student in _students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Teacher person = (Teacher)obj;
            
            bool isStudentsEqual = false;
            if (this.Students.Count != person.Students.Count)
                return false;
            else
                for (int i = 0; i <this.Students.Count; i++ )
                {
                    if (!this.Students[i].Equals(person.Students[i]))
                        return false;
                    isStudentsEqual = true;
                }
            return  (base.Equals(person) && isStudentsEqual);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override string ToString()
        {
            string toStringOutput = "";
            foreach (Student student in _students)
            {
                toStringOutput += student;
            }
            return String.Format($"Teacher: {base.ToString()}Teacher's students: {toStringOutput}\n");
        }

    }
}
