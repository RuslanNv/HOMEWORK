using System;

namespace HomeWork1
{
    class Man
    {
        string _firstName;
        string _lastName;
        int _age;
        string _gender;
        int _weight;

        public Man(string fname, string lname, string gender, int age, int weight)
        {
            FirstName = fname;
            LastName = lname;
            Gender = gender;
            Age = age;
            Weight = weight;
        }

        public string FirstName
        {
            set
            {
                if(value.Length == 0) { _firstName = "John"; }
                else { _firstName = value; }
            }
            get { return _firstName; }
        }

        public string LastName
        {
            set
            {
                if (value.Length == 0) { _lastName = "Doe"; }
                else { _lastName = value; }
            }
            get { return _lastName; }
        }

        public string Gender
        {
            set
            {
                if(value != "Male" && value != "Female") { _gender = "Male"; }
                else { _gender = value; }
            }
            get { return _gender; }
        }

        public int Age
        {
            set
            {
                if(value <= 0) { _age = 0; }
                else { _age = value; }
            }
            get { return _age; }
        }

        public int Weight
        {
            set
            {
                if(value <= 0) { _weight = 0; }
                else { _weight = value; }
            }
            get { return _weight; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Полное имя: {0} {1}", FirstName, LastName);
            Console.WriteLine("Пол: {0}", Gender);
            if(Age == 0)
            { Console.WriteLine("Возраст: нет данных"); }
            else
            { Console.WriteLine("Возраст: {0} лет", Age); }
            if (Weight == 0)
            { Console.WriteLine("Вес: нет данных"); }
            else
            { Console.WriteLine("Вес: {0} кг", Weight); }
        }

    }
}
