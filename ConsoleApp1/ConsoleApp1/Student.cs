namespace ConsoleApp1
{
    public class Student
    {
        
        public string fname { get; set; }
        public string lname { get; set; }
        public int indexNumber { get; set; }
        public string birthdate { get; set; }
        public string email { get; set; }
        public string mothersName { get; set; }
        public string fatherName { get; set; }
        public Studies studies { get; set; }
    }

    public class Studies
    {
        public string name { get; set; }
        public string mode { get; set; }
    }



}