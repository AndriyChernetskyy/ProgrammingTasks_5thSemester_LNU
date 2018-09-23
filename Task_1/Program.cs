using System;
using System.Collections.Generic;

namespace Task_1
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>();
            Teacher teacher = new Teacher("Teach", 30, stud);
            Student student = new Student("Vasa",20, teacher);
            Console.WriteLine(student);
            Console.Read();
        }
    }
}
