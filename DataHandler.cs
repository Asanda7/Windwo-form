using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllReadFormat
{
    class DataHandler
    {

        public List<string> format(List<string> data)
        {
            List<string> peoples = new List<string>();

            foreach (string line in data)
            {
                string[] items = line.Split(',');
                Person P = new Person(items[0], items[1], items[2]);
                peoples.Add(P);
            }
            List<string> formattedData = new List<string>();

            foreach(Person P in peoples)
            {
                Console.WriteLine(P);
                formattedData.Add(P.ToString());
            }
            return formattedData;

        }



    }
}
