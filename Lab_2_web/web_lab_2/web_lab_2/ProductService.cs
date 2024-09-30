using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace web_lab_2
{
    internal class ProductService
    {
        public void add(Product  p)
        {
            StreamWriter streamWriter = new StreamWriter("products.txt", append: true);
            streamWriter.WriteLine(p.GetProductInfo());
            streamWriter.Close();
        }
        public string get(int id)
        {
            FileStream file = new FileStream("products.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            string data = streamReader.ReadLine();
            while(data!=null)
            {
                String[] dataInfo = data.Split(',');
                if (int.Parse(dataInfo[0])==id)
                {
                    streamReader.Close();
                    file.Close();
                    return data;
                }
                data = streamReader.ReadLine();
            }
            streamReader.Close();
            file.Close();
            return "";
        }
        public  string getAllProducts() 
        {
            FileStream file = new FileStream("products.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            string loopCounter = streamReader.ReadLine();
            string data = loopCounter;
            while(loopCounter!=null)
            {
                data += '\n';
               // Console.WriteLine("Id : "+loopCounter);
                loopCounter= streamReader.ReadLine();
                data += loopCounter;
            }
            streamReader.Close();
            file.Close();
            return data;

        }
    }
}
