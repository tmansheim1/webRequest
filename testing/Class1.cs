using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string sURL;
            Console.Write("Enter Drink Name:");
            string drink;
            drink = Console.ReadLine();
            sURL = "www.thecocktaildb.com/api/json/v1/1/search.php?s=" + drink;

            WebRequest geturl;
            geturl = WebRequest.Create(sURL);
            Stream objStream;
            objStream = geturl.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);
            string str = objReader.ReadToEnd();
            Console.Write(str);
        }
    }
}
