using ConsoleApp1.Utils;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queryOutput =  new QueryOutput();
            var queries = new Queries();

            IEnumerable<object> query = queries.GetAllStudents();
            queryOutput.DisplayResult(query, "Get all students from the list");

            query = queries.GetAllTeachersPositions();
            queryOutput.DisplayResult(query, "Get all teachers' positions");

            query = queries.GetStudentsOfSpecificYear(2002);
            queryOutput.DisplayResult(query, "Get students born in 2002");

            query = queries.GetStudentsByFirstLetter('T');
            queryOutput.DisplayResult(query, "Get students whose names start with \'T\'");

            query = queries.GetTeacherWithMostStudents();
            queryOutput.DisplayResult(query, "Get teacher who has the most students");

            query = queries.GetStudentsByGroupName("IS-03");
            queryOutput.DisplayResult(query, "Get students whose group name is \'IS-03\'");

            query = queries.GetSortedStudentNames();
            queryOutput.DisplayResult(query, "Get sorted student names");

            query = queries.GetStudentsSortedByMarks();
            queryOutput.DisplayResult(query, "Get students sorted by their average marks");

            query = queries.GetStudentsSortedByBirthDay();
            queryOutput.DisplayResult(query, "Get student names sorted by their birthdays in descending order");

            query = queries.GetTeacherByMostStudentGroupName("IS-03");
            queryOutput.DisplayResult(query, "Get teacher with the most instances of students from the \'IS-03\' group ");

            query = queries.GetStudentsByGroupNameAndMarks("IS-03", 80);
            queryOutput.DisplayResult(query, "Get students from \'IS-03\' group with average marks > 80");

            query = queries.GetTeachersWithBestStudents();
            queryOutput.DisplayResult(query, "Get teachers with the students who have the highest average mark");

            query = queries.GetTeachersWithWorstStudents();
            queryOutput.DisplayResult(query, "Get teachers with the students who have the lowest average mark");

            var groups = queries.GroupStudentsByGroup();
            queryOutput.DisplayGroupedStudentsResult(groups);

            var teachersGroups = queries.GroupTeachersByStudentsAmount();
            queryOutput.DisplayGroupedTeachersResult(teachersGroups);
        }
    }
}
