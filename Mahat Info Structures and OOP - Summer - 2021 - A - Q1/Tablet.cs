using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahat_Info_Structures_and_OOP___Summer___2021___A___Q1
{
    internal class Tablet
    {
        public string Name { get; set; }
        public string Kind { get; set; }
        public char System { get; set; }
        public double Size { get; set; }
        public double Price { get; set; }



        public Tablet(string name, string kind,char system, double size, double price)
        {
            Name = name;
            Kind = kind;
            Size = size;
            Price = price;
            System = System;
        }

        public bool IsSame(Tablet other)
        {
            if (Name == other.Name && Kind == other.Kind && Size == other.Size)
                return true;
            else
                return false;
        }




    }
}


    



