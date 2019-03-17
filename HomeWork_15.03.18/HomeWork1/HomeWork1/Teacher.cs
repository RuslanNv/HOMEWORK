using System;

namespace HomeWork1
{
    class Teacher : Man
    {
        string _subject;
        int _experience;

        public Teacher(string fname, string lname, string gender, int age, int weight, string subject, int experience)
                        :base(fname, lname, gender, age, weight)
        {
            Subject = subject;
            Experience = experience;
        }

        public string Subject
        {
            set { _subject = value; }
            get { return _subject; }
        }

        public int Experience
        {
            set
            {
                if(value < 0) { _experience = 0; }
                else { _experience = value; }
            }
            get { return _experience; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Является преподавателем");
            Console.WriteLine("Преподаваемый предмет: {0}", Subject);
            Console.WriteLine("Стаж: {0} лет", Experience);
        }

        public void AddYears(Student student, int years)
        {
            student.IncreaseSY(years);
        }
    }
}
