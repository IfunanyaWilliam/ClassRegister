

class Program
    {
        static void Main()
        {
        //DotNetClass dotNet = new DotNetClass();
        Student student = new Student()
        { //Object initialization of properties
            FirstName = "Ifunanya",
            LastName = "Onah",
            Gender = 0,
            Gadgets = new string[] { "Dell Laptop", "iPhone12 Promax", "Backpack", "Face cap" }
        };

        new Student()
        { //Object initialization of properties
            FirstName = "Isreal",
            LastName = "Eze",
            Gender = 0,
            Gadgets = new string[] { "HP", "iPhone14 Promax", "Backpack" }
        };

            DotNetClass dotNet = new DotNetClass(student);
        }
    }

public enum Gender
{
    Male, 
    Female,
    Other
}



//class object
//field representing total number of students 
//field representing the list of the students in the class
//method to set the number of students
//mehtod to add students 
//method to remove students
//class name
//class description


//student object
//student name
//student gender
//student gadgets