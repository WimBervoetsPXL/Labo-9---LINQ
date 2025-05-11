using StudentScores.Entities;
using StudentScores.Models;
using System.Windows.Navigation;

namespace StudentScores.Data
{
    public class StudentStore
    {
        private List<Student> _students;

        public StudentStore()
        {
            _students = new List<Student>
                {
                new Student { FirstName = "Lotte", LastName = "Vermeulen", Grade = 6, Department = "Business" },
                new Student { FirstName = "Fien", LastName = "Wouters", Grade = 17, Department = "Design" },
                new Student { FirstName = "Robbe", LastName = "Verbeeck", Grade = 19, Department = "IT" },
                new Student { FirstName = "Tess", LastName = "Wouters", Grade = 16, Department = "Business" },
                new Student { FirstName = "Lina", LastName = "Hermans", Grade = 19, Department = "Marketing" },
                new Student { FirstName = "Sam", LastName = "Schoofs", Grade = 11, Department = "Business" },
                new Student { FirstName = "Olivia", LastName = "Buyens", Grade = 9, Department = "Marketing" },
                new Student { FirstName = "Eva", LastName = "Stevens", Grade = 17, Department = "Design" },
                new Student { FirstName = "Jasper", LastName = "Van Damme", Grade = 18, Department = "Business" },
                new Student { FirstName = "Bram", LastName = "Moens", Grade = 7, Department = "Marketing" },
                new Student { FirstName = "Jasper", LastName = "Goossens", Grade = 14, Department = "Business" },
                new Student { FirstName = "Mats", LastName = "Cools", Grade = 9, Department = "Business" },
                new Student { FirstName = "Liam", LastName = "Declerck", Grade = 8, Department = "Marketing" },
                new Student { FirstName = "Eva", LastName = "Wouters", Grade = 19, Department = "IT" },
                new Student { FirstName = "Laura", LastName = "Schoofs", Grade = 19, Department = "Business" },
                new Student { FirstName = "Sam", LastName = "Segers", Grade = 15, Department = "Design" },
                new Student { FirstName = "Adam", LastName = "Moens", Grade = 10, Department = "Marketing" },
                new Student { FirstName = "Anna", LastName = "Goossens", Grade = 19, Department = "IT" },
                new Student { FirstName = "Simon", LastName = "Smets", Grade = 6, Department = "Marketing" },
                new Student { FirstName = "Noah", LastName = "Lambert", Grade = 16, Department = "Design" },
                new Student { FirstName = "Lina", LastName = "Verbeeck", Grade = 12, Department = "Design" },
                new Student { FirstName = "Mats", LastName = "Lambert", Grade = 16, Department = "Business" },
                new Student { FirstName = "Kobe", LastName = "Wouters", Grade = 8, Department = "Marketing" },
                new Student { FirstName = "Cedric", LastName = "Peeters", Grade = 6, Department = "Design" },
                new Student { FirstName = "Adam", LastName = "Lambert", Grade = 12, Department = "Design" },
                new Student { FirstName = "Jules", LastName = "Schoofs", Grade = 13, Department = "Business" },
                new Student { FirstName = "Daan", LastName = "Cools", Grade = 20, Department = "Marketing" },
                new Student { FirstName = "Cedric", LastName = "De Backer", Grade = 17, Department = "Design" },
                new Student { FirstName = "Elise", LastName = "Desmet", Grade = 7, Department = "IT" },
                new Student { FirstName = "Luna", LastName = "Mertens", Grade = 8, Department = "IT" },
                new Student { FirstName = "Amber", LastName = "Hermans", Grade = 14, Department = "Design" },
                new Student { FirstName = "Julie", LastName = "Maes", Grade = 14, Department = "Marketing" },
                new Student { FirstName = "Finn", LastName = "Vandamme", Grade = 17, Department = "Design" },
                new Student { FirstName = "Eline", LastName = "Vandamme", Grade = 15, Department = "IT" },
                new Student { FirstName = "Lucas", LastName = "Moens", Grade = 11, Department = "Marketing" },
                new Student { FirstName = "Liam", LastName = "Van Damme", Grade = 18, Department = "IT" },
                new Student { FirstName = "Maud", LastName = "Hermans", Grade = 17, Department = "IT" },
                new Student { FirstName = "Jules", LastName = "Stevens", Grade = 11, Department = "Marketing" },
                new Student { FirstName = "Anna", LastName = "Dumoulin", Grade = 9, Department = "Marketing" },
                new Student { FirstName = "Bo", LastName = "Buyens", Grade = 19, Department = "Business" },
                new Student { FirstName = "Mila", LastName = "Willems", Grade = 11, Department = "IT" },
                new Student { FirstName = "Hanne", LastName = "Segers", Grade = 9, Department = "IT" },
                new Student { FirstName = "Simon", LastName = "Lambert", Grade = 13, Department = "IT" },
                new Student { FirstName = "Finn", LastName = "De Clercq", Grade = 16, Department = "Marketing" },
                new Student { FirstName = "Viktor", LastName = "Wouters", Grade = 9, Department = "Marketing" },
                new Student { FirstName = "Hanne", LastName = "Buyens", Grade = 12, Department = "IT" },
                new Student { FirstName = "Fien", LastName = "Cools", Grade = 10, Department = "IT" },
                new Student { FirstName = "Jules", LastName = "Buyens", Grade = 11, Department = "Marketing" },
                new Student { FirstName = "Mats", LastName = "Jacobs", Grade = 13, Department = "Design" },
                new Student { FirstName = "Jules", LastName = "Dumoulin", Grade = 15, Department = "Marketing" },
                };
        }

        //1
        public Student[] AllStudents() => _students.ToArray();

        //2
        public IEnumerable<Student> PassedStudents()
        {
            return _students.Where(s => s.Grade > 10);
        }

        //3
        public List<Student> SortedByFirstName()
        {
            return _students.OrderBy(s => s.FirstName).ToList();
        }

        //3.1
        public List<Student> SortedByFirstNameThenByLastname()
        {
            return _students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName).ToList();
        }

        //4
        public IEnumerable<DepartmentCount> NumberOfStudentsByDepartment()
        {
            return _students
                .GroupBy(s => s.Department)
                .Select(g => new DepartmentCount { Department = g.Key, Count = g.Count() });
        }

        //5
        public GradeSummary Summary {
            get {
                //Helaas niet mogelijk in 1 linq statement (niet ondersteund)
                var summary = new GradeSummary
                {
                    NumberOfStudents = _students.Count(),
                    AverageScore = _students.Average(s => s.Grade),
                    MinimumScore = _students.Min(s => s.Grade),
                    MaximumScore = _students.Max(s => s.Grade),
                };
                return summary;
            }
        }

        //6
        public int NumberOfDepartments()
        {
            return _students.Select(s => s.Department).Distinct().Count();
        }

        //Extra 1
        public IEnumerable<Student> StudentsWithHonor()
        {
            return _students.Where(s => s.Grade >= 14)
                .OrderByDescending(s => s.Grade)
                .ThenBy(s => s.LastName)
                .ThenBy(s => s.FirstName);

        }

        //Extra 2
        public IEnumerable<Student> StudentsByDepartment(string department)
        {
            return _students.Where(s => s.Department.Equals(department, StringComparison.OrdinalIgnoreCase));
        }

        //Extra 3
        public IEnumerable<Student> BestStudentPerDepartment()
        {
            var result = _students
                .GroupBy(s => s.Department)
                .Select(g => g
                    .OrderByDescending(s => s.Grade)
                    .First())
                .OrderBy(s => s.Department);
            return result;

            //OF
            var result2 = _students
                .GroupBy(s => s.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    TopStudent = g.OrderByDescending(s => s.Grade).First()
                })
                .Select(a => new Student
                {
                    Department = a.Department,
                    FirstName = a.TopStudent.FirstName,
                    LastName = a.TopStudent.LastName,
                    Grade = a.TopStudent.Grade,
                })
                .OrderBy(s => s.Department).ToList();

            //OF
            //nieuwe class aanmaken voor resultaat
        }

        //Extra 4
        public List<Student> Top3()
        {
            return _students.OrderByDescending(s => s.Grade).Take(3).ToList();
        }

        //Extra 5
        public List<Student> Top3PerDepartment(List<Student> students)
        {
            return students
                .GroupBy(s => s.Department)
                .SelectMany(g => g
                    .OrderByDescending(s => s.Grade)
                    .Take(3)
                    .Select(s => s)
                )
                .ToList();
        }

        //Extra 6
        public List<DepartmentStats> GetDepartmentStatistics(List<Student> students)
        {
            return students
                .GroupBy(s => s.Department)
                .Select(g => new DepartmentStats
                {
                    Department = g.Key,
                    StudentCount = g.Count(),
                    AverageScore = g.Average(s => s.Grade),
                    MinScore = g.Min(s => s.Grade),
                    MaxScore = g.Max(s => s.Grade)
                })
                .OrderBy(ds => ds.AverageScore)
                .ToList();
        }

        //Extra 7
        public List<Student> StudentsByName(string name)
        {
            return _students
                .Where(s => s.FirstName.Equals(name) || s.LastName.Equals(name))
                .ToList();
        }
    }
}
