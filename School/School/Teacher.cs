using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Teacher
    {
        // Fields
        private List<Subject> subjects = new List<Subject>();
        private string name;

        // Properties
        // May Remove
        public Subject[] Subjects
        {
            get
            {
                return this.subjects.ToArray();
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        // Constructor
        public Teacher(string name)
        {
            this.name = name;
        }

        // Methods
        public void AddSubject(Subject subject)
        {
            this.subjects.Add(subject);
        }
    }
}
