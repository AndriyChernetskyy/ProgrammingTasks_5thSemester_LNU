using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task_1
{
    static class Program
    {
        static void Main(string[] args)
        {
            var dictionary = File.ReadAllLines("input_info.txt")
              .Select(l => l.Split(new[] { ':' }))
              .ToDictionary(s => s[0].Trim(), s => s[1].Split(new[] { ',' }));

            var teachers = new List<Teacher>();
            var students = new List<Student>();
            var studentsInTeacher = new List<Student>(); 

            foreach(var i in dictionary)
            {
                foreach (var j in i.Value)
                {
                    studentsInTeacher.Add(new Student(j.Split('=')[0], int.Parse(j.Split('=')[1])));
                    teachers.Add(new Teacher(i.Key.Split('=')[0], int.Parse(i.Key.Split('=')[1]), studentsInTeacher));
                }
            }

            var people = new List<Person>();

            foreach(var i in teachers)
            { 
                people.Add(i);
                foreach (var j in i.Students)
                {
                    j.Teacher = new Teacher(i.FullName, i.Age, i.Students);
                    people.Add(j);
                }
            }

           foreach (var person in people)
            {
                person.Print();
            }

            var copiedPeople = new List<Person>(people.Select(x => (Person)x.Clone()));
            foreach(var i in copiedPeople)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
            

        }
    }
}
