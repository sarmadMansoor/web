using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_lab_2
{
    public class Electronics:Product
    {
        int warrantyPeriod;
        public int WarrantyPeriod { get {return warrantyPeriod; } set {warrantyPeriod=value; } }
        public override  string GetProductInfo()
        {
            return $"{Id},Name : {Name},Price: {Price},Warranty Period: {warrantyPeriod}";
        }
    }
}
