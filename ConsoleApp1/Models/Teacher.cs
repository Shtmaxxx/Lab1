using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public List<Student> Students { get; set; }

        public Teacher(string name, string position, List<Student> students)
        {
            Name = name;   
            Position = position;
            Students = students;
        }

        public override string ToString()
        {
            return $"Name = {Name}; Position = {Position}; Students Count = {Students.Count}";
        }
    }
}
