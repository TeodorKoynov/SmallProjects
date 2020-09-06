using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> list1 = new GenericList<string>(5);
            list1.AddElement("Gogo");
            list1.AddElement("Igrae");
            list1.AddElement("Futball");
            list1.DeleteElement(2);
            Console.WriteLine(list1.MyToString());
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            list1.AddElement("gogo");
            Console.WriteLine(list1.MyToString() + " " + list1.Length);
            Console.WriteLine(list1.EmptyIndexes);
        }
    }
}
