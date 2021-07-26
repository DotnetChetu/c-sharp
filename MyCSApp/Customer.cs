using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSApp
{
    class BankingCustomer
    {
        public string AcNo { get; }
        public string Name;
        public string Email;
        private decimal _Amount;

        public BankingCustomer(string acno,string name, string email,decimal amount)
        {
            this.AcNo = acno;
            this.Name = name;
            this.Email = email;
            this._Amount = amount;
        }

       

        public decimal Amount
        {
            get { return this._Amount; }
            set
            {
                if (value > 1000)
                {
                    this._Amount = value;
                }
                else
                {
                    throw new Exception("Insufficient amount, transaction failed !");

                }
            }
        }

    }
}
