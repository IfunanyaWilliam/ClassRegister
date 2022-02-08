


public class Student
{
    private string _fullName;

    public Student()
    { //This is useful for automatic assignment of Id 
        Id = Guid.NewGuid();
    }
    public string FirstName { get; set; }

    public Guid Id { get; }    //This property cannot be set

    public string LastName { get; set; }

    //private description for set ensures that it can only be set from within the class
    public string FullName 
    {
        get
        {
            return _fullName;
        } 
        private set 
        {
            //_fullName = !string.IsNullOrWhiteSpace(LastName ) ? ${ LastName} { FirstName} : FirstName;
            _fullName = !string.IsNullOrWhiteSpace(LastName) ? LastName + " " + FirstName : FirstName; 
        }
            
    }

    public Gender Gender {   get; set; }

    public string[] Gadgets { get; set; }

    public override string ToString()
    {
        return base.ToString();
        {
            return $"Id: {Id}\nFullName: {FullName}\nGender : {Gender}\nGadgets"
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