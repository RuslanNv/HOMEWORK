using System;

namespace HomeWork1
{
    class Program
    {
        static void Main()
        {
            Man man = new Man("Иванов", "Иван", "Male", 20, 85);
            man.ShowInfo();
            Console.WriteLine();
            Student student = new Student("Петров", "Петр", "Male", 19, 56, 4);
            student.ShowInfo();
            Console.WriteLine();
            Teacher teacher = new Teacher("Сидорова", "Ольга", "Female", 30, 49, "Высшая матеамтика", 8);
            teacher.ShowInfo();
            Console.WriteLine();
            teacher.AddYears(student, 3);
            Console.WriteLine();
            Console.WriteLine(student.StudyYears);
            Console.ReadLine();
        }
    }
}
