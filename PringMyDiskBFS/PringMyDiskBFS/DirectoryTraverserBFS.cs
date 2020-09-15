using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PringMyDiskBFS
{
    public static class DirectoryTraverserBFS
    {
        public static void PrintMyDisk(string dirPath)
        {
            Queue<DirectoryInfo> visitedDirs = new Queue<DirectoryInfo>();
            visitedDirs.Enqueue(new DirectoryInfo(dirPath));

            while (visitedDirs.Count > 0)
            {
                DirectoryInfo visitedDir = visitedDirs.Dequeue();
                Console.WriteLine(visitedDir.FullName);

                DirectoryInfo[] dirs = visitedDir.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    visitedDirs.Enqueue(dir);
                }
            }
        }
    }
}
