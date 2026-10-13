

using System.Reflection.Metadata;

namespace StudentLibrary
{
    class Student
    {
        // create private fields to store student ID, name, and age
        private int id;
        private string name;
        private int age;
        // add private static integer 'studentCount', initialsie to 0, make it read only
        private static int studentCount = 0;  // its 'static' because it is shared among all instances of the class


        public int Id         //property
        {
            get { return id; }
            private set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public static int StudentCount
        {
            get { return studentCount; }
        }



        //dafault constructor, takes no parameters. Sets fields to following default values 
        public Student()
        {
            id = studentCount++;
            name = "John Doe";
            age = 16; 
        }


        // custom constructor (parameterised). Set the student’s ID with the class variable and increment the variable 
        public Student(string name, int age)
        {
            this.id = studentCount++;
            this.name = name;
            this.age = age;
        }



        // add methods

        // prints out student's ID, name and age.
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }

        // increases student age by 1 year, returns student's age
        public int GetOlder()
        {
            return ++age;
        }

    }
}
