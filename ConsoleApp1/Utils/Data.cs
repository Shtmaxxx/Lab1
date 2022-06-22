using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    internal static class Data
    {
        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student("Victor Mills", "IS-03", new DateTime(2002, 12, 27), 70),
            new Student("Nile Feeney", "IS-03", new DateTime(2001, 11, 12), 62),
            new Student("Harry Watson", "IS-03", new DateTime(2000, 1, 3), 73),
            new Student("Pamela Rehbein", "IP-03", new DateTime(2003, 12, 27), 67),
            new Student("Tilda Harrison", "IA-03", new DateTime(2002, 10, 26), 72),
            new Student("Jimmy Bowen", "IS-03", new DateTime(2002, 10, 27), 73),
            new Student("Nicole Holt", "IS-03", new DateTime(2000, 12, 20), 98),
            new Student("Sandra Harvey", "IK-03", new DateTime(2002, 3, 4), 96),
            new Student("Beatrice Robbins", "IA-03", new DateTime(2002, 4, 12), 82),
            new Student("Truman Stanley", "IS-03", new DateTime(2002, 12, 27), 88),
        };

        public static List<Teacher> Teachers { get; set; } = new List<Teacher>()
        {
            new Teacher("Sophie Pauley", "Computer Science Teacher", new List<Student>()
            {
                Students[0],
                Students[1],
                Students[2],
            }),
            new Teacher("David Smith", "Biology Teacher", new List<Student>()
            {
                Students[3],
                Students[4],
                Students[5],
                Students[6],
            }),
            new Teacher("Mike Red", "Maths Teacher", new List<Student>()
            {
                Students[7],
                Students[8],
                Students[9],
            }),
        };
    }
}
