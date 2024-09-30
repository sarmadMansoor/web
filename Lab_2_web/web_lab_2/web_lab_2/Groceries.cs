using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_lab_2
{
    internal class Groceries:Product
    {
        string date;
        public string Date { get {return date; } set {date=value; } }
        public override string  GetProductInfo()
        {
            return $"{Id},Name: {Name},Price: {Price},Date : {date}";
        }
    }
}
