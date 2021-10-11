using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newData = new List<string>() {"9", "1", "2", "3", "4", "9","10", "5", "5", "6", "7", "8", "5", "9", "10", "9", "11", "9", "5", "12" };
            foreach (var item in newData)
            {
                FileStorage.AddFile(item);
            }

            Console.ReadLine();
            
            //Add to a list
            //Make sure the number of items in the list does not exceed 10
            //Make the last item into the list be the first to appear and then delete the first to enter
            //check if such item exist already if yes delete that item with its  index and add it again
        }
    }

    public static class FileStorage
    {
        static List<string> addFile = new List<string>();
        public static List<string> AddFile(string data)
        {
            if (addFile.Count() == 10)
            {
                addFile.RemoveAt(addFile.Count - 1);
                if (addFile.Exists(x => x.Contains(data)))
                {
                    addFile.RemoveAt(addFile.IndexOf(data));
                    addFile.Insert(0, data);
                }
                else
                {
                    addFile.Insert(0, data);
                }
            }
            else if (addFile.Count <= 10)
            {
                if (addFile.Exists(x => x.Contains(data)))
                {
                    addFile.RemoveAt(addFile.IndexOf(data));
                    addFile.Insert(0, data);
                }
                else
                {
                    addFile.Insert(0, data);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Recent Entries : {string.Join(',', addFile)}");
            return addFile;
        }
    }
}