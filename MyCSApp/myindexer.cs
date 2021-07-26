using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSApp
{
    class myindexer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string this[int index]
        {
            get
            {
                if (index == 0)
                    return this.Name;
                else if (index == 1)
                    return this.Email;
                else
                    throw new Exception("index not found !");
            }

            set
            {
                if (index == 0)
                    this.Name = value;
                else if (index == 1)
                    this.Email = value;
                else
                    throw new Exception("index not found !");
            }
        }

        public string this[string key]
        {
            get
            {
                if (key == "name")
                    return this.Name;
                else if (key == "email")
                    return this.Email;
                else
                    throw new Exception("index not found !");
            }

            set
            {
                if (key == "name")
                    this.Name = value;
                else if (key == "email")
                    this.Email = value;
                else
                    throw new Exception("index not found !");
            }
        }
    }
}
