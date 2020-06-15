using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson4_Part1
{
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string m_studentID;

        // PUBLIC PROPERTIES

        public string StudentID
        {

            get // accessor
            {
                return m_studentID;
            }

            set // mutator
            {
                m_studentID = value;
            }
        }


        // CONSTRUCTOR
        public Student(string name, int age, string student_id)
            :base(name, age)
        {
            StudentID = student_id;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public void Studies()
        {
            Console.WriteLine($"{Name} is Studying.");
        }

        /// <summary>
        /// This method overrides the superclass ToString Method
        /// </summary>
        /// <returns>
        /// This method returns a formatted string that displays class properties
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += "\n+++++++++++++++++++++++++++++++\n";
            outputString += $" Name      : {Name}         \n";
            outputString += $" Age       : {Age}          \n";
            outputString += $" StudentID : {StudentID}    \n";
            outputString += "+++++++++++++++++++++++++++++++\n";

            return outputString;
        }
    }
}
