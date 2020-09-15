using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace PrintMyDisk
{
    public static class DirectoryTraverserDFS
    {
        private static void TraverserDFS(DirectoryInfo dir, string seprator)
        {
            Console.WriteLine(seprator + dir.FullName);

            DirectoryInfo[] children = dir.GetDirectories();
            foreach (DirectoryInfo child in children)
            {
                TraverserDFS(child, seprator + " ");
            }
        }

        public static void PrintTraverserDFS(string directoryPath)
        {
            TraverserDFS(new DirectoryInfo(directoryPath), string.Empty);
        }

    }
}
