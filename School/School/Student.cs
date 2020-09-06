using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Student
    {
        // Fields
        private string firstName;
        private string lastName;
        private int numInClass;

        // Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }
        public int NumInClass
        {
            get
            {
                return this.numInClass;
            }
        }

        // Constructor
        public Student(string firstName, string lastName, int numInClass)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.numInClass = numInClass;
        }
        
        // Methods
    }
}
