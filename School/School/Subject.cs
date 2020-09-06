using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Subject
    {
        // Fields
        private string name;
        private int numberOfLessons;
        private int numberOfExcersices;

        // Properties

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public int NumberOfLessons
        {
            get
            {
                return this.numberOfLessons;
            }
        }
        private int NumberOfExcersices
        {
            get
            {
                return this.numberOfExcersices;
            }
        }

        // Constructor
        public Subject(string name, int numberOfLessons, int numberOfExcersices)
        {
            this.name = name;
            this.numberOfLessons = numberOfLessons;
            this.numberOfExcersices = numberOfExcersices;
        }
    }
}
