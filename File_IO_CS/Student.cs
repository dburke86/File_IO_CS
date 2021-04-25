using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_CS
{
    class Student : Person
    {
        public Student(string first, string last, string gender, int age)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Gender = gender;
            this.Age = age;
        }

        public override void move()
        {

        }
    }
}
//Write the info from the student or the instructor object that is created in the application code, to a file for persistence
//Read the file, populate a new object with the information, and then display the results on the console window
