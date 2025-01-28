using System;

namespace Homework
{
    // Derived class
    public class MathAssignment : Assignment
    {
        // Private member variables specific to MathAssignment
        private string _textbookSection;
        private string _problems;

        // Constructor
        public MathAssignment(string studentName, string topic, string textbookSection, string problems)
            : base(studentName, topic) // Call the base class constructor
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        // Method to return the homework list
        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
    }
}