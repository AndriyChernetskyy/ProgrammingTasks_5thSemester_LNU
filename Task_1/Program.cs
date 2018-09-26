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

            List<Teacher> teachers = new List<Teacher>();

            foreach(var i in dictionary)
            {
                foreach (var j in i.Value)
                {
                    teachers.Add(new Teacher(i.Key.Split('=')[0], int.Parse(i.Key.Split('=')[1]), new List<Student>() { new Student(j.Split('=')[0], int.Parse(j.Split('=')[1])) }));
                }
            }

            List<Person> people = new List<Person>();

            foreach(var i in teachers)
            {
                people.Add(i);
                foreach (var j in i.Students)
                {
                    j.Teacher = new Teacher(i.FullName, i.Age, i.Students);
                    people.Add(j);
                }
            } 
            
            //Можеш протестити це чи норм виводить
            foreach(var i in people)
            {
                Console.WriteLine(i);
            }


            var copiedPeople = new List<Person>(people.Select(x => (Person)x.Clone()));


        }
    }
}
