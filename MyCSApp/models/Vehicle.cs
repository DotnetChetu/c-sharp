using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSApp.models
{

    public class X
    {
        public virtual  void P() { Console.WriteLine("P"); }
    }
    public class Y:X
    {
        public sealed override void P() { Console.WriteLine("P"); }

    }

    class Vehicle
    {
      

        public virtual void Move()
        {
            Console.WriteLine("Vehicle moving...");
        }
    }
}
