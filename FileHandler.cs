using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AllReadFormat
{
    class FileHandler
    {
        // 1 . method Read to File 
        public List<string> Read()
        {
            List<string> data = new List<string>();
            data = File.ReadAllLines("FileText.txt").ToList();
            foreach (string Line in data)
            {
                Console.WriteLine(Line);
            }
            Console.WriteLine() ;
            return data;
        }

        public void Write(List<string> formattedData)
        {
            Console.WriteLine();
            File.WriteAllLines("CreateText.txt", formattedData);
            Console.WriteLine("Successful to Write");
        }



    }
}
