using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class Item
    {
        string date;
        string str;

        public Item()
        {
        }

        public Item(string date, string str)
        {
            this.date = date;
            this.str = str;
        }

        public string Date { get => date; set => date = value; }
        public string Str { get => str; set => str = value; }
    }
}
