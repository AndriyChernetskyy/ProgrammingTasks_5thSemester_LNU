using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public abstract class Person : ICloneable
    {
        private string _fullname;
        private int _age;

        public string FullName
        {
            get { return _fullname; }
            set { _fullname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Person()
        {
            FullName = "";
            Age = 0;
        }

        public Person(string fullName,int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        public virtual void Input() {
            Console.WriteLine("Enter person's name: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Enter person's age: ");
            Age = Convert.ToInt32(Console.Read());
        }

        public virtual void Print() {
            Console.WriteLine($"Name: {this.FullName}, age: {this.Age}");
        }

        public override string ToString()
        {
            return String.Format($"Name: {this.FullName}, age: {this.Age}\n");
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;
            Person person = (Person)obj;
            return (this.FullName == person.FullName && this.Age == person.Age);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
    }
}
