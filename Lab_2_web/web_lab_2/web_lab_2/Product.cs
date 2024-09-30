using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_lab_2
{
    public class Product
    {
        private int id;
        private string name;
        private double  price;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double  Price { get {return price; } set {price=value; } }
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Description: {Price}";
        }
        public virtual  string GetProductInfo()
        {
            return $"{Id},Name : {Name},Price: {Price}";
        }

    }
}
