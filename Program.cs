using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerMesseger.Classes;
using System.Data.Entity;

namespace ServerMesseger
{
    class Program
    {
        static UserContext db = new UserContext();
        static void Main(string[] args)
        {
            foreach(var u in db.Users)
            {
                Console.WriteLine(u.Loggin);
            }
        }
    }
}
