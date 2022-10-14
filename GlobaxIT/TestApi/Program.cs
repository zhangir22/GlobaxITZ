using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net.Sockets;
using Newtonsoft.Json;
namespace TestApi
{
    internal class Program
    {
        public class ContainerUser
        {
            public User[] users { get; set; }
        }
        public class User
        {
            public  string name { get; set; }
            public  string phone { get; set; }
            public  string addres { get; set; }
            public  string position_name { get; set; }
            public  string department { get; set; }
            public  DateTime hire_date { get; set; }
        }
      
        static void Main(string[] args)
        {
            IList<User> lst = null;
            ContainerUser container = new ContainerUser();
            using (StreamReader str = new StreamReader("users.json"))
            {
                lst = JsonConvert.DeserializeObject<IList<User>>(str.ReadToEnd());

            }
            foreach(var item in lst)
            {
                Console.WriteLine(item.name); 
            }
            Console.ReadLine();
        }
    }
}
