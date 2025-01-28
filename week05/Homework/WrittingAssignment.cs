using System;

namespace Homework
{
    // Derived class
    public class WritingAssignment : Assignment
    {
        // Private member variables specific to WritingAssignment
        private string _title;

        // Constructor
        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic) // Call the base class constructor
        {
            _title = title;
        }

        // Method to return the writing information
        public string GetWritingInformation()
        {
            return $"{_title} by {GetStudentName()}";
        }
    }
}