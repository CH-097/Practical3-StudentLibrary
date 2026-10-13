

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




        //dafault constructor, takes no parameters. Sets fields to following default values 
        public Student()
        {
            this.id = studentCount++;
            this.name = "John Doe";
            this.age = 16; 
        }


        // custom constructor, takes a name and age parameter.Set the student’s ID with the class variable and increment the variable




    }
}
