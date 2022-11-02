using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllReadFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHandler L = new DataHandler();
            FileHandler Fg = new FileHandler();

            Fg.Write(L.format(Fg.Read()));

            Console.ReadLine();
        }
    }
}
