using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public string getCourseName()
        { 
            return courseName;
        }
        public string getInstructorName()
        { 
            return instructorName; 
        }

        public void setCourseName(string cName)
        {
            cName=  courseName;
        }
        public void setInstructorName(string instrucName)
        {
            if (instrucName != "")
            {
                instrucName = instructorName;
            }
        }
        public double getGrade()
        {
             return grade;
        }
        public void setGrade(double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
            }
            this.grade = grade;
        }
        private string CalculateLetterGrade()
        {

            if (grade >= 75 && grade <= 100)
            {
                return "A";
            }
            else if (grade >= 65)
            {
                return "B";
            }
            else if (grade >= 55)
            {
                return "C";
            }
            else if (grade >= 45)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }

        public void printCourseInfo()
        {
            Console.WriteLine("Couse Name: " + courseName);
            Console.WriteLine("Instructor Name: " + instructorName);
            Console.WriteLine("Grade: " + CalculateLetterGrade());
        }

    }
}
