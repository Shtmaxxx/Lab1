using ConsoleApp1.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Utils
{
    internal class Queries
    {
        private List<Student> _students = Data.Students;
        private List<Teacher> _teachers = Data.Teachers;
        public IEnumerable<Student> GetAllStudents()
        {
            return from student in _students
                   select student;
        }

        public IEnumerable<string> GetAllTeachersPositions()
        {
            return from teacher in _teachers
                   select teacher.Position;
        }

        public IEnumerable<Student> GetStudentsOfSpecificYear(int year)
        {
            return from student in _students
                   where student.BirthDay.Year == year
                   select student;
        }

        public IEnumerable<Student> GetStudentsByFirstLetter(char letter)
        {
            return from student in _students
                   where student.Name[0] == letter
                   orderby student.BirthDay ascending
                   select student;
        }

        public IEnumerable<Teacher> GetTeacherWithMostStudents()
        {
            return from teacher in _teachers
                   where teacher.Students.Count ==
                        _teachers.Max(x => x.Students.Count)
                   select teacher;
        }

        public IEnumerable<object> GetStudentsByGroupName(string groupName)
        {
            return from student in _students
                   where student.Group == groupName
                   select new { student.Name, student.Group };
        }

        public IEnumerable<object> GetSortedStudentNames()
        {
            return _students.OrderBy(student => student.Name).Select(x => new {x.Name});
        }

        public IEnumerable<object> GetStudentsSortedByMarks()
        {
            return _students.OrderByDescending(student => student.AverageMark).
                        Select(x => new {x.Name, x.AverageMark});
        }

        public IEnumerable<object> GetStudentsSortedByBirthDay()
        {
            return _students.OrderByDescending(s => s.BirthDay).
                        Select(y => new { y.Name, y.BirthDay });
        }

        // Get teacher with the most instances of students from the given group 
        public IEnumerable<object> GetTeacherByMostStudentGroupName(string groupName)
        {
            return _teachers.Where(t => t.Students.Where(s => s.Group == groupName).Count() ==
                       _teachers.Max(t => t.Students.Where(s => s.Group == groupName).Count()))
                           .Select(t => t.Name);
        }

        public IEnumerable<object> GetStudentsByGroupNameAndMarks(string groupName, int mark)
        {
            return _students.Where(s => s.Group == groupName && s.AverageMark > mark).
                        Select(x => new {x.Name, x.Group, x.AverageMark});
        }


        // Get teachers with students who have the highest average mark
        public IEnumerable<object> GetTeachersWithBestStudents()
        {
            return _teachers.Where(t => t.Students.Where(s => s.AverageMark ==
                        _students.Max(x => x.AverageMark)).Count() > 0).
                            Select(a => a.Name);
        }

        // Get teachers with students who have the lowest average mark
        public IEnumerable<object> GetTeachersWithWorstStudents()
        {
            return _teachers.Where(t => t.Students.Where(s => s.AverageMark ==
                        _students.Min(x => x.AverageMark)).Count() > 0).
                            Select(a => a.Name);
        }

        public IEnumerable<IGrouping<string, Student>> GroupStudentsByGroup()
        {
            return _students.GroupBy(x => x.Group);
        }

        public IEnumerable<IGrouping<int, Teacher>> GroupTeachersByStudentsAmount()
        {
            return _teachers.GroupBy(t => t.Students.Count);
        }
    }
}
