using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    class SchoolClass
    {
        // Fields
        private string className;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();

        // Properties
        public string ClassName
        {
            get
            {
                return this.className;
            }
        }

        // May Remove
        public Teacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
        }
        public Student[] Seachers
        {
            get
            {
                return this.students.ToArray();
            }
        }

        // Constructor
        public SchoolClass(string name)
        {
            this.className = name;
        }

        // Methods 
        public void AddStudent(params Student[] students)
        {
            foreach (Student student in students)
            {
                this.students.Add(student);
            }
        }

        public void AddTeacher(params Teacher[] teachers)
        {
            foreach (Teacher teacher in teachers)
            {
                this.teachers.Add(teacher);
            }
        }

        public void PrintStudents()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].FirstName + " " + students[i].LastName + " " + students[i].NumInClass);
            }
        }

        public void DeleteStudent(int number)
        {
            int classNumber = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].NumInClass == number)
                {
                    classNumber = students[i].NumInClass;
                    Student emptySlot = new Student("Empty", "Slot", classNumber);
                    students[i] = emptySlot;
                }
            }
        }

    }
}
