using System;

namespace HomeWork1
{
    class Student : Man
    {
        int studyYears;

        public Student(string fname, string lname, string gender, int age, int weight, int year) 
                : base(fname,lname,gender,age,weight)
        {
            studyYears = year;
        }

        public int StudyYears { get {return studyYears; } }

        public void IncreaseSY(int increment)
        {
            studyYears += increment;
            Console.WriteLine("Студенту по имени {0} {1}  срок обучения увеличен до {2} лет", FirstName, LastName, StudyYears);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Является студентом");
            Console.WriteLine("Лет до завершения обучения: {0} лет", StudyYears);
        }
    }
}
