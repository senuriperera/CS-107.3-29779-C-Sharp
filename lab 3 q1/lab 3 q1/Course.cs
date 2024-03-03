using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_q1
{
    internal class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public string CourseName
        { 
            get { return courseName; } 
        }
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Grade must be between 0 and 100");
                grade = value;
            }
        }

        public Course(string courseName, string instructorName, double grade)
        {
            this.courseName = courseName;
            SetInstructorName(instructorName);
            Grade = grade;
        }

        public void SetInstructorName(string instructorName)
        {
            if (string.IsNullOrWhiteSpace(instructorName))
                throw new ArgumentException("Instructor name cannot be empty");
            this.instructorName = instructorName;
        }

        private string CalculateLetterGrade()
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }

        public void PrintCourseInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Instructor Name: {instructorName}");
            Console.WriteLine($"Letter Grade: {CalculateLetterGrade()}");
        }
    }
}
