using System; 
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class Student : Person
    {
        private Teacher _teacher;

        public Teacher Teacher {
            get { return _teacher; }
            set {_teacher = value; }
        }

        public Student():base() 
        {
            _teacher = null;
        }

        public Student(string fullName, int age):base(fullName, age)
        {
     //       this.Teacher = teacher;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter student's teacher: ");
            Teacher.Input();
        }

        public override void Print()
        {
            Console.WriteLine("Student: ");
            base.Print();
            Console.WriteLine("Student's teacher: ");
            Console.WriteLine(Teacher);
            
         
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;
            Student person = (Student)obj;
            return (this.Teacher.Equals(person.Teacher) && base.Equals(person));
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format($"Student: { base.ToString()}");
        }

    }
}
