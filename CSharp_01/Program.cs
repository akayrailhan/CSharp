using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region write

            //Console.WriteLine("Hello World!");
            //Console.Write("Hi Bros");

            #endregion

            string name;
            name = "John Doe";

            Console.WriteLine("Hello " + name);

            string customerSurname = "Smith";

            Console.WriteLine(customerSurname);

            Console.Read();
        }
    }
} 