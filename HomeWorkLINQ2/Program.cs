namespace HomeWorkLINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadLine();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudents = (from student in classes
                              from s in student.Students
                              select s).ToArray();
            return allStudents;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}