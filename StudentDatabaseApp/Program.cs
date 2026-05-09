using System;

namespace StudentDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started...");

            using (var context = new SchoolContext())
            {
                var student = new Student()
                {
                    StudentName = "John Doe"
                };

                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully");
            Console.ReadLine();
        }
    }
}