using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolClass a = new SchoolClass("a");
            SchoolClass b = new SchoolClass("b");
            SchoolClass v = new SchoolClass("v");
            SchoolClass g = new SchoolClass("g");
            School school = new School("MG");
            school.AddSchoolClass(a, b, v, g);
            school.DeleteSchoolClass("a");
            School.PrintAllClasses(school);
            Teacher teacher1 = new Teacher("Gogo1");
            Teacher teacher2 = new Teacher("Gogo2");
            Teacher teacher3 = new Teacher("Gogo3");
            Teacher teacher4 = new Teacher("Gogo4");
            school.AddTeacher(teacher1, teacher2, teacher3, teacher4);
            school.DeleteTeacher("Gogo2");
            Subject subject = new Subject("Biology", 14, 14);
            teacher1.AddSubject(subject);
            school.PrintTeachers();
            Student student1 = new Student("Gogo", "Ivanov", 1);
            Student student2 = new Student("Ivan", "Ivanov", 3);
            Student student3 = new Student("Dimitar", "Ivanov", 2);
            Student student4 = new Student("Bojidar", "Ivanov", 4);
            a.AddStudent(student1, student3, student2, student4);
            a.PrintStudents();

        }
    }
}
