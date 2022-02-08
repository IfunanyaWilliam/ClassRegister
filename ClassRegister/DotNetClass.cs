

public class DotNetClass
{       
    
    public DotNetClass(Student[] students)  //constructor method
    {
        Students = students;
        ClassSize = students.Length;    
    }

    public int ClassSize { get; }           
    public Student[] Students { get; }       

    public void PrintClassDetails()
    {
        foreach (Student dev in Students)
        {
            Console.WriteLine(dev.ToString());
        }
    }

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