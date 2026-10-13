using StudentLibrary;


class Program
{
    static void Main(string[] args)
    {
        // create object using the default constructor
        Student student1 = new Student();
        // create object using the custom constructor
        Student student2 = new Student("Jane Doe", 18);


        // display details of both students using Display method
        student1.Display();
        student2.Display();
        // call the GetOlder method for both objects then print student detail again
        student1.GetOlder();
        student2.GetOlder();

        student1.Display();
        student2.Display();

        /*
         * ID: 0, Name: John Doe, Age: 16
           ID: 1, Name: Jane Doe, Age: 18
           ID: 0, Name: John Doe, Age: 17
           ID: 1, Name: Jane Doe, Age: 19
        */
    }
}

