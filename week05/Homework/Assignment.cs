using System;

namespace Homework
{
    // Base class
    public class Assignment
    {
        // Private member variables
        private string _studentName;
        private string _topic;

        // Constructor
        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        // Method to return a summary of the assignment
        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }

        // Protected method to access the student name in derived classes
        protected string GetStudentName()
        {
            return _studentName;
        }
    }
}