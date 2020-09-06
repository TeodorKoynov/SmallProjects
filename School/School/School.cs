using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    class School
    {
        // Fields
        private string name;
        private List<SchoolClass> schoolClasses = new List<SchoolClass>();
        private List<Teacher> teachers = new List<Teacher>();

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        // Constructors
        public School(string name)
        {
            this.name = name;
        }

        public School(string name, SchoolClass[] schoolClasses, Teacher[] teachers)
        {
            this.name = name;
            this.schoolClasses = schoolClasses.ToList();
            this.teachers = teachers.ToList();
        }

        // Methods
        public void AddSchoolClass(params SchoolClass[] schoolClasses)
        {
            foreach (SchoolClass schoolClass in schoolClasses)
            {
                this.schoolClasses.Add(schoolClass);
            }
        }

        public void DeleteSchoolClass(string name)
        {
            bool notUnsigned = true;
            int index = 0;
            for (int i = 0; i < schoolClasses.Count; i++)
            {
                if (schoolClasses[i].ClassName == name)
                {
                    schoolClasses[i] = null;
                    index = i;
                    notUnsigned = false;
                }
            }
            if (notUnsigned != true )
            {
                for (int i = index; i < schoolClasses.Count - 1; i++)
                {
                    schoolClasses[i] = schoolClasses[i + 1];
                }
                schoolClasses.RemoveAt(schoolClasses.Count - 1);
            }
        }

        public static void PrintAllClasses(School school)
        {
            Console.WriteLine("*-----Classes:-----*\n");
            foreach (SchoolClass schoolClass in school.schoolClasses)
            {
                Console.WriteLine($"|------> {schoolClass.ClassName}");
            }
            Console.WriteLine("____________________");
        }

        public void AddTeacher(params Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                this.teachers.Add(teachers[i]);
            }
        }

        public void DeleteTeacher(string name)
        {
            int index = -1;
            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i].Name == name)
                {
                    teachers[i] = null;
                    index = i;
                }
            }
            if (index != -1)
            {
                for (int i = index; i < teachers.Count - 1; i++)
                {
                    teachers[i] = teachers[i + 1];
                }
                teachers.Remove(teachers[teachers.Count - 1]);
            }
        }

        public void PrintTeachers()
        {
            int number = 1;
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine($"|==>  {number}" + teachers[i].Name + " ");
                foreach (Subject subject in teachers[i].Subjects)
                {
                    Console.Write("----> "+ subject.Name + "\n");
                }
                number++;
                Console.WriteLine("_______________________");
            }
        }
    }
}
