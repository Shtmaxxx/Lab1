using System;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        public string Name { get; set; }   
        public string Group { get; set; }
        public DateTime BirthDay { get; set; }
        public int AverageMark { get; set; }

        public Student(string name, string group, DateTime birthDay, int averageMark)
        {
            Name = name;    
            Group = group;
            BirthDay = birthDay;
            AverageMark = averageMark;
        }

        public override string ToString()
        {
            return $"Name = {Name}; Group = {Group}; Birthday = {BirthDay.ToString("dd-MM-yyyy")}; AverageMark = {AverageMark}";
        }
    }
}
