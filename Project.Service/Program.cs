using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new VehicleDBContext())
            {
                var make = from m in db.VehicleMakes
                           orderby m.Name
                           select m.Name ;
                foreach(var item in make)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
