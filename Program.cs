using System.Transactions;

namespace Assignment_2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 2.1.1
             * Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), 
             * StudentLname (string ), StudentGrade ( char ) and public properties for each data member. 
             * Instantiate the class and assign data to properties. Display the data back on console.
             * 
             * Assignment 2.1.2
             * Design a class hierarchy of your choice. (Need only class files )
             */

            Student student = new Student();

            Console.WriteLine($"New student");

            Console.WriteLine("\nEnter student ID:");
            student.IdNumber = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("\nEnter student first name:");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("\nEnter student last name:");
            student.LastName = Console.ReadLine();

            Console.WriteLine("\nEnter student grade:");
            student.Grade = Convert.ToChar( Console.Read() );

            Console.WriteLine($"\nYou have created a new profile for {student.FirstName} {student.LastName} with ID number {student.IdNumber} and submitted a grade ({student.Grade})");
            
            Console.WriteLine($"\n{student.FirstName} {student.LastName}'s teacher is {student.TeacherFullname} in classroom {student.RoomNumber}");
        }
    }

    class Student : Classroom
    {
        private int _idNumber;
        public int IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private char _grade;
        public char Grade
        {
            get { return _grade; }
            set { _grade = char.ToUpper(value); }
        }
    }

    class Classroom
    {
        private string _teacherFullName = "John Devries";
        public string TeacherFullname
        {
            get { return _teacherFullName; }
        }

        private string _roomNumber = "16";
        public string RoomNumber
        {
            get { return _roomNumber; }
        }
    }
}
